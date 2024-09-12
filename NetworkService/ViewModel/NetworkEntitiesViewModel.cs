using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using NetworkService.Model;

namespace NetworkService.ViewModel
{
    public class NetworkEntitiesViewModel : BindableBase
    {
        public List<string> ComboBoxItems { get; set; } = ComboBoxImages.PredefinedImages.DERTypes.Keys.ToList();

        public ObservableCollection<DER> EntitiesToShow { get; set; }
        public ObservableCollection<DER> Entities { get; set; }
        public ObservableCollection<DER> FilteredEntities { get; set; }

        public MyICommand AddDERCommand { get; set; }
        public MyICommand DeleteDERCommand { get; set; }
        public MyICommand FilterDERCommand { get; set; }
        public MyICommand ResetFilterCommand { get; set; }
        public MyICommand HelpCommand { get; set; }


        // Unos novog entiteta
        private DER currentDER = new DER();
        private Model.Type currentDERType = new Model.Type();

        // Entitet selektovan u datagridu
        private DER selectedDER;

        // Filtriranje
        private string selectedDERTypeToFilter;
        private bool isSelectedId;
        private bool isSelectedType;
        private string selectedIdMarginToFilterText;
        
        private string filterErrorMessage;

        // Prikaz broja entiteta po tipu
        private int solarRectangleWidth;
        private int solarCount = 0;
        private string solarPercentage;
        private int windRectangleWidth;
        private int windCount = 0;
        private string windPercentage;

        private bool isHelpVisible;

        public Visibility HelpVisibility => IsHelpVisible ? Visibility.Visible : Visibility.Collapsed;


        public NetworkEntitiesViewModel()
        {
            Entities = new ObservableCollection<DER>();
            EntitiesToShow = Entities;

            LoadDefaultValuesForDisplay();

            AddDERCommand = new MyICommand(OnAdd);
            DeleteDERCommand = new MyICommand(OnDelete, CanDelete);
            FilterDERCommand = new MyICommand(OnFilter);
            ResetFilterCommand = new MyICommand(OnResetFilter);
            HelpCommand = new MyICommand(OnHelp);
        }

        private void LoadDefaultValuesForDisplay()
        {
            solarRectangleWidth = 80;
            windRectangleWidth = 80;

            solarPercentage = "50% (0)";
            windPercentage = "50% (0)";
        }

        public DER SelectedDER
        {
            get { return selectedDER; }
            set
            {
                selectedDER = value;
                DeleteDERCommand.RaiseCanExecuteChanged();
            }
        }

        public bool IsHelpVisible
        {
            get { return isHelpVisible; }
            set
            {
                isHelpVisible = value;
                RaisePropertyChanged("IsHelpVisible");
                RaisePropertyChanged("HelpVisibility");
            }
        }

        public string SelectedDERTypeToFilter
        {
            get { return selectedDERTypeToFilter; }
            set
            {
                selectedDERTypeToFilter = value;
                RaisePropertyChanged("SelectedDERTypeToFilter");
            }
        }

        public bool IsSelectedId
        {
            get { return isSelectedId; }
            set
            {
                isSelectedId = value;
                RaisePropertyChanged("IsSelectedId");
            }
        }

        public bool IsSelectedType
        {
            get { return isSelectedType; }
            set
            {
                isSelectedType = value;
                RaisePropertyChanged("IsSelectedType");
            }
        }

        public string SelectedIdMarginToFilterText
        {
            get { return selectedIdMarginToFilterText; }
            set
            {
                selectedIdMarginToFilterText = value;
                RaisePropertyChanged("SelectedIdMarginToFilterText");
            }
        }

      

        public string FilterErrorMessage
        {
            get { return filterErrorMessage; }
            set
            {
                filterErrorMessage = value;
                RaisePropertyChanged("FilterErrorMessage");
            }
        }

        private void OnFilter()
        {
            FilterErrorMessage = String.Empty;

            if (SelectedDERTypeToFilter == null &&
                !IsSelectedId &&
                !IsSelectedType &&
                string.IsNullOrWhiteSpace(SelectedIdMarginToFilterText) )
            {
                FilterErrorMessage = "Fields can't be empty.";
                return;
            }

            List<DER> filteredList = new List<DER>();

            foreach (DER DER in Entities)
            {
                filteredList.Add(DER);
            }

           

            if (IsSelectedId)
            {
                List<DER> entitiesToDelete = new List<DER>();

                if (string.IsNullOrWhiteSpace(SelectedIdMarginToFilterText))
                {
                    FilterErrorMessage = "Id is required.";
                }
                else
                {
                    int selectedId;
                    bool parsingSuccessful = int.TryParse(SelectedIdMarginToFilterText, out selectedId);

                    if (parsingSuccessful)
                    {
                        FilterErrorMessage = String.Empty;

                        if (selectedId >= 0)
                        {
                            FilterErrorMessage = String.Empty;

                            for (int i = 0; i < filteredList.Count; i++)
                            {
                                if (filteredList[i].Id != selectedId)
                                {
                                    entitiesToDelete.Add(filteredList[i]);
                                }
                            }

                            foreach (DER DER in entitiesToDelete)
                            {
                                filteredList.Remove(DER);
                            }
                        }
                        else
                        {
                            FilterErrorMessage = "Id can't be negative.";
                        }
                    }
                    else
                    {
                        FilterErrorMessage = "Id must be an integer.";
                    }
                }
            }
            else if (IsSelectedType)
            {
                List<DER> entitiesToDelete = new List<DER>();

                if (string.IsNullOrWhiteSpace(SelectedIdMarginToFilterText))
                {
                    FilterErrorMessage = "Type is required.";
                }
                else
                {
                    string selectedType = SelectedIdMarginToFilterText;

                        FilterErrorMessage = String.Empty;

                            for (int i = 0; i < filteredList.Count; i++)
                            {
                                if (filteredList[i].Type.Name != selectedType )
                                {
                                    entitiesToDelete.Add(filteredList[i]);
                                }
                            }

                            foreach (DER DER in entitiesToDelete)
                            {
                                filteredList.Remove(DER);
                            }
                        
                    
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(SelectedIdMarginToFilterText))
                {
                    FilterErrorMessage = "Select 'id' or 'type'.";
                }
            }


            if (filteredList.Count > 0)
            {
                FilteredEntities = new ObservableCollection<DER>();

                foreach (DER DER in filteredList)
                {
                    FilteredEntities.Add(DER);
                }

                EntitiesToShow = FilteredEntities;
                RaisePropertyChanged("EntitiesToShow");
            }
            else
            {
                FilterErrorMessage = "No entities to show.";
                EntitiesToShow = Entities;
                RaisePropertyChanged("EntitiesToShow");
            }
        }

        private void OnResetFilter()
        {
            SelectedDERTypeToFilter = null;
            IsSelectedId = false;
            IsSelectedType = false;
            SelectedIdMarginToFilterText = String.Empty;
            FilterErrorMessage = String.Empty;

            EntitiesToShow = Entities;
            FilteredEntities = new ObservableCollection<DER>();
            RaisePropertyChanged("EntitiesToShow");
        }

        private bool CanDelete()
        {
            return SelectedDER != null;
        }

        private void OnDelete()
        {
            switch (SelectedDER.Type.Name)
            {
                case "SolarPanel":
                    solarCount--;
                    break;
                case "WindGenerator":
                    windCount--;
                    break;
            }

            Entities.Remove(SelectedDER);

            OnDataGridUpdate();
        }

        public DER CurrentDER
        {
            get { return currentDER; }
            set
            {
                currentDER = value;
                RaisePropertyChanged("CurrentDER");
            }
        }

        public Model.Type CurrentDERType
        {
            get { return currentDERType; }
            set
            {
                currentDERType = value;
                RaisePropertyChanged("CurrentDERType");
            }
        }

        private void OnDataGridUpdate()
        {
            if (Entities.Count > 0)
            {
                int tempsolarPercentage = solarCount * 100 / (solarCount + windCount);
                int tempwindPercentage = windCount * 100 / (solarCount + windCount);

                solarPercentage = $"{tempsolarPercentage}% ({solarCount})";
                windPercentage = $"{tempwindPercentage}% ({windCount})";

                if (tempsolarPercentage == 100)
                {
                    solarRectangleWidth = 400 * tempsolarPercentage / 100;
                    windRectangleWidth = 400 - solarRectangleWidth;
                    windPercentage = "";
                }
                else if (tempwindPercentage == 100)
                {
                    solarRectangleWidth = 400 * tempsolarPercentage / 100;
                    windRectangleWidth = 400 - solarRectangleWidth;
                    solarPercentage = "";
                }
                else
                {
                    solarRectangleWidth = 400 * tempsolarPercentage / 100;
                    windRectangleWidth = 400 - solarRectangleWidth;
                }
            }
            else
            {
                LoadDefaultValuesForDisplay();
            }

        }

        public void OnAdd()
        {
            try
            {
                int parsedId;
                bool canParse = int.TryParse(CurrentDER.TextId, out parsedId);
                bool idAlreadyExists = false;

                if (canParse)
                {
                    foreach (DER DER in Entities)
                    {
                        if (DER.Id == parsedId)
                        {
                            idAlreadyExists = true;
                            break;
                        }
                    }
                }

                CurrentDER.DoesIdAlreadyExist = idAlreadyExists;

                CurrentDER.Validate();
                CurrentDERType.Validate();

                if (CurrentDER.IsValid)
                {
                    Entities.Add(new DER()
                    {
                        Id = int.Parse(CurrentDER.TextId),
                        Name = CurrentDER.Name,
                        Type = new Model.Type
                        {
                            Name = CurrentDERType.Name,
                            PathToPhoto = CurrentDERType.PathToPhoto
                        },
                        Value = 0
                    });

                    switch (CurrentDERType.Name)
                    {
                        case "SolarPanel":
                            solarCount++;
                            break;
                        case "WindGenerator":
                            windCount++;
                            break;
                    }

                    OnDataGridUpdate();

                    CurrentDER.TextId = String.Empty;
                    CurrentDER.Name = String.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{DateTime.Now} - {ex.Message}");
            }
        }

        public void OnHelp()
        {

            IsHelpVisible = !IsHelpVisible;
        }


        public int SolarRectangleWidth
        {
            get { return solarRectangleWidth; }
            set
            {
                solarRectangleWidth = value;
                RaisePropertyChanged("solarRectangleWidth");
            }
        }

        public string SolarPercentage
        {
            get { return solarPercentage; }
            set
            {
                solarPercentage = value;
                RaisePropertyChanged("solarPercentage");
            }
        }

        public int WindRectangleWidth
        {
            get { return windRectangleWidth; }
            set
            {
                windRectangleWidth = value;
                RaisePropertyChanged("windRectangleWidth");
            }
        }

        public string WindPercentage
        {
            get { return windPercentage; }
            set
            {
                windPercentage = value;
                RaisePropertyChanged("windPercentage");
            }
        }
    }
}
