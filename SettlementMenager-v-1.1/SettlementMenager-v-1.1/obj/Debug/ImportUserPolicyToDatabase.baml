   M S B A M L   `   `   `  ����R  NSettlementMenager-v-1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SettlementMenager_v_1._1SettlementMenager_v_1._1  5   	   9    3SettlementMenager_v_1._1.ImportUserPolicyToDatabase   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SettlementMenager_v_1._1     5   	   -   5        #��Z��5   	   #��Z��5	   	     � Title$  Importuj plik Excel��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ 	Maximized=�5   	    � Language$ pl-PL�5   	   .��5      (� .��5   
   � $	��829��6   $
��1520��6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $"��usersDatagridImportFromExcel��5      $
��Left=�6;   $
��1510��6V   $	��687��6c   $��Bottom=�6p   $��10,0,0,121.4q�6�      CanUserAddRows .     
IsReadOnly .    AutoGenerateColumns .  
�������
���   �   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   	   MinWidth$	 70Q�6T   
   MaxWidth$	
 255Q�6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
importedId+   ElementStyle 5      �� 5       �� 
TargetType" ��6$   .�5   "   ��  �� Property � �� �� Value$
 Wrap=�6K   �� 5   "    � ��$
 Left=�6H   6W   �� 5   "    � ��$ Stretch=�6F   6X   �� 5   "    �@��TextAlignment$
 Left=�6L   6[   �� 5    "    � ��$ Center=�6P   6a   5!      5#        5&      $
 Data��6)   $	 70Q�6n   $	
 255Q�6|    67   �� *importedDataPolicy+ �� StringFormat$ d�� 5'      �� 5(      " ��6$   .�5)   "   ��  � ��$
 Wrap=�6K   �� 5*   "    � ��$
 Left=�6H   6W   �� 5+   "    � ��$ Stretch=�6F   6X   �� 5,   "    �@��TextAlignment$
 Left=�6L   6[   �� 5-   "    � ��$ Center=�6P   6a   5.      50        53      $ 	Nr polisy��6)   $		 120Q�6e   $	
 255Q�6t    6<   �� *importedPolicyNumber+ 54      �� 55      " ��6$   .�56   "   ��  � ��$
 Wrap=�6K   �� 57   "    � ��$
 Left=�6H   6W   �� 58   "    � ��$ Stretch=�6F   6X   �� 59   "    �@��TextAlignment$
 Left=�6L   6[   �� 5:   "    � ��$ Center=�6P   6a   5;      5=        5@      $ Wystawiający��6)   $		 120Q�6k   $	
 255Q�6z    6?   �� *importedUserPolicyOwner+ 5A      �� 5B      " ��6$   .�5C   "   ��  � ��$
 Wrap=�6K   �� 5D   "    � ��$
 Left=�6H   6W   �� 5E   "    � ��$ Stretch=�6F   6X   �� 5F   "    �@��TextAlignment$
 Left=�6L   6[   �� 5G   "    � ��$ Center=�6P   6a   5H      5J        5M      $ Ubezpieczający��6)   $		 120Q�6e   $	
 255Q�6t    6A   �� *importedInsurer+ 5N      �� 5O      " ��6$   .�5P   "   ��  � ��$
 Wrap=�6K   �� 5Q   "    � ��$
 Left=�6H   6W   �� 5R   "    � ��$ Stretch=�6F   6X   �� 5S   "    �@��TextAlignment$
 Left=�6L   6[   �� 5T   "    � ��$ Center=�6P   6a   5U      5W        5Z      $ Zdjęcia��6)   $		 120Q�6^   $	
 255Q�6m    6:   �� *importedPicture+ 5[      �� 5\      " ��6$   .�5]   "   ��  � ��$
 Wrap=�6K   �� 5^   "    � ��$
 Left=�6H   6W   �� 5_   "    � ��$ Stretch=�6F   6X   �� 5`   "    �@��TextAlignment$
 Left=�6L   6[   �� 5a   "    � ��$ Center=�6P   6a   5b      5d        5g      $ 	Agent mm6��6)   $	 70Q�6[   $	
 255Q�6i    6<   �� *
ImportedM6+ 5h      �� 5i      " ��6$   .�5j   "   ��  � ��$
 Wrap=�6K   �� 5k   "    � ��$
 Left=�6H   6W   �� 5l   "    � ��$ Stretch=�6F   6X   �� 5m   "    �@��TextAlignment$
 Left=�6L   6[   �� 5n   "    � ��$ Center=�6P   6a   5o      5q        5t      $ Status��6)   $		 120Q�6\   $	
 255Q�6k    69   �� *importedStatus+ 5u      �� 5v      " ��6$   .�5w   "   ��  � ��$
 Wrap=�6K   �� 5x   "    � ��$
 Left=�6H   6W   �� 5y   "    � ��$ Stretch=�6F   6X   �� 5z   "    �@��TextAlignment$
 Left=�6L   6[   �� 5{   "    � ��$ Center=�6P   6a   5|      5~        5�      $ 
Pośrednik��6)   $	 90Q�6_   $	
 255Q�6m    6<   �� *importedBroker+ 5�      �� 5�      " ��6$   .�5�   "   ��  � ��$
 Wrap=�6K   �� 5�   "    � ��$
 Left=�6H   6W   �� 5�   "    � ��$ Stretch=�6F   6X   �� 5�   "    �@��TextAlignment$
 Left=�6L   6[   �� 5�   "    � ��$ Center=�6P   6a   5�      5�        5�      $ Public��6)   $	 70Q�6\   $	
 255Q�6j    69   �� *importedPublic+ 5�      �� 5�      " ��6$   .�5�   "   ��  � ��$
 Wrap=�6K   �� 5�   "    � ��$
 Left=�6H   6W   �� 5�   "    � ��$ Stretch=�6F   6X   �� 5�   "    �@��TextAlignment$
 Left=�6L   6[   �� 5�   "    � ��$ Center=�6P   6a   5�      5�        5�      $ Agencja��6)   $		 120Q�6b   $	
 255Q�6q    6:   �� *importedPolicyOwner+ 5�      �� 5�      " ��6$   .�5�   "   ��  � ��$
 Wrap=�6K   �� 5�   "    � ��$
 Left=�6H   6W   �� 5�   "    � ��$ Stretch=�6F   6X   �� 5�   "    �@��TextAlignment$
 Left=�6L   6[   �� 5�   "    � ��$ Center=�6P   6a   5�      5�        5�      $ Uwagi��6)   $		 120Q�6`   $	
 255Q�6o    68   �� *importedCashpayment+ 5�      �� 5�      " ��6$   .�5�   "   ��  � ��$
 Wrap=�6K   �� 5�   "    � ��$
 Left=�6H   6W   �� 5�   "    � ��$ Stretch=�6F   6X   �� 5�   "    �@��TextAlignment$
 Left=�6L   6[   �� 5�   "    � ��$ Center=�6P   6a   5�      5�      5�      �� 5�      -   5        $��openExcelFile��5�      $��Otwórz plik��6*   $
��Left=�6@   $��1168,729,0,0q�6[   $	��Top=�6q   $��75��6�    J� RenderTransformOrigin$ 
8.973,0.73&�6�   6�   �� 5�      -   5        $��importDatagridToDatabase��5�      $��Zapisz do bazy��65   $
��Left=�6N   $	��Top=�6i   $	��108��6�   $��41��6�   $��
10,718,0,0q�6�   6�   �� 5�      -   5        $��removeItemFromList��5�      $��Usuń element z listy��6/   $
��Left=�6N   $	��Top=�6i   $	��172��6�   $��123,718,0,0q�6�   $��41��6�   6�   �� 5�      $
��Left=�6   $��10,5,0,0q�63   $
��Wrap=�6E   $#��Lista polis do zaimportowania��6Y   $	��Top=�6~   $	��211��6�   �� 5�      -   5        $��importedExcelPath��5�      $
��Left=�6/   $��19��6J    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��272��6�   $��1248,729,0,0q�6�   �� 5�      $��Wystawiający��6   $
��Left=�6+   $	��Top=�6F   $��334,723,0,0q�6^   $��80��6s   �� 5�      -   5        $��chosePolicyOwnerCombobox��5�      $
��Left=�67   $	��Top=�6R   $	��210��6j   $��419,726,0,0q�6v   5�      5�      5�      