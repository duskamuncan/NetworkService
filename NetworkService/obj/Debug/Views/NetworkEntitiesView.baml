   M S B A M L   `   `   `  ����I  ENetworkService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:NetworkService.ViewsNetworkService.Views  5      .    (NetworkService.Views.NetworkEntitiesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:NetworkService.Views     5      .��5	      � .+�5
   
   ��   �� Orientation$  Vertical=�6   $��Center=�6,   .+�5      �� $  
Horizontal=�6   $
��Left=�62   .+�5      �� $  Vertical=�6   $��5,0,0,0q�64   .+�5      	� -   5         	�Name$ radioButtonLessThan��5   "   $��id��6?   
������� d� 	IsChecked 6^   �� *IsSelectedId+ �� Mode$ TwoWay=�	� 5      -   5        $ radioButtonGreaterThan��5   "   $
��type��6B   
������� 6c   �� *IsSelectedType+$ TwoWay=�5      �� 5      -   5         ��Name$ textBoxIdToFilter��5      $	��110��6q   $��20��6}   $��5,0,0,0q�6�   ��65   �� *SelectedIdMarginToFilterText+$ TwoWay=�6�   �� 5      -   5         ��Name$ buttonFilter��5      $��SEARCH��6/   $��50��6e   $��20��6p   $��6,0,0,0q�6|   ��6@   �� *FilterDERCommand+6|   �� 5      -   5        $ buttonReset��5      $��RESET��6.    � ToolTip$ Reset search criteria��6>   $��40��6�   $��20��6�   $��6,0,0,0q�6�   ��6^   �� *ResetFilterCommand+6�   �� 5      -   5        $ 
buttonHelp��5      $	��SOS��6-   $ Click for help��6;   $��40��6t   $��20��6   $��	220,0,0,0q�6�   ��6T   �� *HelpCommand+6�   5      �� 5      
���  ��$	��115��6M    �� TextAlignment$ Center=�6Y   $
��Left=�6p   $��	132,0,0,0q�6�   ��6   �� *FilterErrorMessage+6�   �� 5      $  
Horizontal=�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridEntities��5      
�������$	��160��6�   $	��399��6�   $
��Left=�6�   $��0,5,0,0q�6�   	   	RowHeight$	 20Q�6�   
   
IsReadOnly
 .    SelectionMode$ Single=�6�      AutoGenerateColumns .     CanUserAddRows .     CanUserReorderColumns .     CanUserResizeColumns .  "   VerticalScrollBarVisibility$ Hidden=�6  ��.  ��65   �� *EntitiesToShow+ �� SelectedItem 6\   �� *SelectedDER+ � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell �� 
TargetType��%,  '        '  L     �� 5      "  6    .�5      ��  � ��$ Center=�6K   5       �� 5!      "  6    .�5"      ��  � �� 5#   "   �� 5$   &   "  66   .R�5%   *   � #��z��6/   .+�5&   .   �� $��Center=�6?   $��Center=�6Z   5'   +   5(   '   5*      5+      5,         Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 115 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Id+6P     5/      $
 Name��6-   $ * 6T    6;   �� *Name+6T     50      $
 Type��6-   $	 115 6Y    6;   �� *	Type.Name+6Y     51      $ Value��6-   $	 115 6V    6<   �� *Value+6V   53      �� 54      
���   �$��15,7,0,0q�6-   $��1q�6?   $	��159��6S   ._�55      �� -   5         ��Name$ helpTextBlock��55       $����This is a table with data. If you want to delete an entity, select it. If you want to search by id or type, enter the criteria. If you want to add a new entity, fill out the form. ��67   $ Center=�6�   $	��170��6
  $	��122��6  $	��Top=�6#  $��0,-3,0,0q�6;  $
��Wrap=�6M  y�6a  �� *HelpVisibility+56      57      �� 58      -	   5        $ titleTextBlock��58      $��Add new entity��60   $��90��6F   $��20��6Q   $��
0,10,220,0q�6]   $
��Bold"�6q   �� 5:      $  
Horizontal=�6   .+�5;      �� $  
Horizontal=�6   $��
0,10,10,10q�66   
�������$	��326��6\   .+�5<      �� $  Vertical=�6!   $	��Top=�68   $��5,10,0,0q�6P   .+�5=      �� $
��Id: ��6$   $
��Auto��60   $
��Auto��6>   $
��Left=�6K   $��Center=�6f   $��0,2,0,0q�6�   �� 5>      $��Name: ��6$   $
��Auto��62   $
��Auto��6@   $
��Left=�6M   $��Center=�6h   $��0,20,0,0q�6�   �� 5?      $��Type: ��6$   $
��Auto��62   $
��Auto��6@   $
��Left=�6M   $��Center=�6h   $��0,22,0,0q�6�   5@      �� 5B      $  Vertical=�6!   $��Center=�68   $��	20,10,0,0q�6S   .+�5C      �� -
   5        $ 	textBoxId��5C   "   $	��150��6e   ��65   �� *CurrentDER.TextId+$ TwoWay=�6e   �� 5D      
���  ��$	��150��6f   ��6$   �� *!CurrentDER.ValidationErrors[Id]+6f   �� 5E      -   5        $ textBoxName��5E   "   $	��150��6e   $��0,5,0,0q�6q   ��67   �� *CurrentDER.Name+$ TwoWay=�6q   �� 5F      
���  ��$	��150��6h   ��6$   �� *#!CurrentDER.ValidationErrors[Name]+6h   �� 5G      -   5         ��Name$ comboBoxDERType2��5G   #   $	��150��6�   $��0,5,0,0q�6�   ��6=   �� *ComboBoxItems+ 6c   �� *CurrentDERType.Name+$ TwoWay=�6�   �� 5H      
���  ��$	��150��6l   ��6$   �� *'%CurrentDERType.ValidationErrors[Name]+6l   5I      � 5K      $��80��6   $��80��6&   $��	20,-9,0,0q�62   
�������.+�5L      �� 
�������$��1q�68   $��Center=�6L   $��Center=�6i   ._�5M      �� $��Uniform=�6_   ��6$   �� *CurrentDERType.PathToPhoto+$ TwoWay=�6_   5N      5O      5Q      �� 5S      $  Vertical=�6   $��Center=�64   $��	30,15,0,0q�6Q   .+�5T      �� 
���   �$��1q�61   $��2,0,0,0q�6E   ._�5U      �� $  
Horizontal=�6%   .+�5V      � 
�������$��90��6:   $��Center=�6E   $��Center=�6`   .+�5W   "   �� $��Solar panel��6,   $ Center=�6@   $��Center=�6W   5X      � 5Y      .+�5Z   "   �� 
���������6=   �� *SolarRectangleWidth+�� 5[   "   $��Center=�6N   $��Center=�6i   ��6,   �� *SolarPercentage+6i   5\      5]      5^      �� 5_      
���   �$��1q�61   $��2,0,0,0q�6E   ._�5`      �� $  
Horizontal=�6%   .+�5b      � 
�������$��90��6:   $��Center=�6E   $��Center=�6`   .+�5c   "   �� $��Wind generator��6,   $ Center=�6D   $��Center=�6[   5d      � 5e      .+�5f   "   �� 
���������6=   �� *WindRectangleWidth+�� 5g   "   $��Center=�6M   $��Center=�6h   ��6,   �� *WindPercentage+6h   5h      5i      5j      5m      5n      �� 5o      $  
Horizontal=�6   $��Center=�62   $��	100,0,0,0q�6M   .+�5p      �� -   5        $ 	buttonAdd��5p      $ Add new entity��6,   $	��ADD��6E   $��50��6S   $��25��6^   ��6j   �� *AddDERCommand+�� 5q      -   5        $ buttonDelete��5q      $ Delete selected entity��6/   $��DELETE��6P   $��50��6a   $��25��6l   $��10,0,0,0q�6�   ��6x   �� *DeleteDERCommand+6�   5r      5s      5t      5u      