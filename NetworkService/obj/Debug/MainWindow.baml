   M S B A M L   `   `   `  ����I  ENetworkService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NetworkServiceNetworkService  5   	   ;"clr-namespace:NetworkService.ViewsNetworkService.Views  5      C&clr-namespace:NetworkService.ViewModelNetworkService.ViewModel  5          NetworkService.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:NetworkService     5   	   4views"clr-namespace:NetworkService.Views     5      =
viewModels&clr-namespace:NetworkService.ViewModel     5        � Title$  
MainWindow��5
   	   $	��500��6   $	��600��6)    � 
ResizeMode$ NoResize=�65    � DataContext 5      2   ,NetworkService.ViewModel.MainWindowViewModel  5   
    � 	Resources 5       �� DataType7   1NetworkService.ViewModel.NetworkEntitiesViewModel.   (NetworkService.Views.NetworkEntitiesView6   0NetworkService.ViewModel.NetworkDisplayViewModel-   'NetworkService.Views.NetworkDisplayView8   2NetworkService.ViewModel.MeasurementGraphViewModel/   )NetworkService.Views.MeasurementGraphView��%�   (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5!   
   ]� $��0��6   $��10q�6!   .+�5"      o� $	��Top=�6   .@�5#      m�  m� CommandParameter$ NetworkEntities��6:    m� Command 6   �� *
NavCommand+��5$      �� 5%      $��Network Entities��6$   $	��140��6<    �� TextAlignment$ Center=�6H   5'      m� 5(      $ NetworkDisplay��6:    6   �� *
NavCommand+��5)      �� 5*      $��Network Display��6$   $	��140��6;   $ Center=�6G   5,      m� 5-      $ MeasurementGraph��6:    6   �� *
NavCommand+��5.      �� 5/      $��Measurement Graph��6$   $	��140��6=   $ Center=�6I   51      52      53      � 54   
   $��1��6   .+�55      �� ��6   �� *CurrentViewModel+56      57      58      