   M S B A M L   `   `   `  ����R  NSettlementMenager-v-1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SettlementMenager_v_1._1SettlementMenager_v_1._1  5   	   @    :SettlementMenager_v_1._1.NotSettledPolicyDocumentsDatagrid   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SettlementMenager_v_1._1     5   	   $	��700��5   	   $	��900��5	   	     � Title$  Nierozliczone polisy��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ Normal=�5   	    � Language$ pl-PL�5   	   .��5      � $	��700��6   $	��900��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $*��$showNotSettledPolicyDocumentDatagrid��5         
IsReadOnly .    AutoGenerateColumns .  $��Stretch=�6m   $��14,70,23,122q�6�   $��Stretch=�6�   $
��Auto��6�   $
��Auto��6�   
�������
���   � J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.055Q�6$   �� 5      T� 5       T� Y$ -0.397Q�6)   5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Data��6%      MinWidth$ 80Q�6`      MaxWidth$	 100Q�6n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *
FullDate+ �� StringFormat$ d��   ElementStyle 5      �� 5        �� 
TargetType" ��6    .�5!      ��  �� Property � �� �� Value$
 Wrap=�6G   �� 5"       � ��$
 Left=�6D   6S   �� 5#       � ��$ Stretch=�6B   6T   �� 5$       �@��TextAlignment$ Center=�6H   6Y   �� 5%       � ��$ Center=�6L   6]   5&      5(        5+      $
 	Nr polisy��6%   $	 150Q�6Y   $	 255Q�6h    68   �� *PolicyNumber+ 5,      �� 5-      " ��6    .�5.      ��  � ��$
 Wrap=�6G   �� 5/       � ��$
 Left=�6D   6S   �� 50       � ��$ Stretch=�6B   6T   �� 51       �@��TextAlignment$
 Left=�6H   6W   �� 52       � ��$ Center=�6L   6]   53      55        58      $
 Wystawiający��6%   $	 180Q�6X   $	 180Q�6g    6;   �� *
UserName+ 59      �� 5:      " ��6    .�5;      ��  � ��$
 Wrap=�6G   �� 5<       � ��$
 Left=�6D   6S   �� 5=       � ��$ Stretch=�6B   6T   �� 5>       �@��TextAlignment$
 Left=�6H   6W   �� 5?       � ��$ Center=�6L   6]   5@      5C        5F      $
 
Pośrednik��6%   $	 130Q�6S   $	 180Q�6b    68   �� *Broker+ 5G      �� 5H      " ��6    .�5I      ��  � ��$
 Wrap=�6G   �� 5J       � ��$
 Left=�6D   6S   �� 5K       � ��$ Stretch=�6B   6T   �� 5L       �@��TextAlignment$
 Left=�6H   6W   �� 5M       � ��$ Center=�6L   6]   5N      5P        5S      $
 Status��6%   $	 130Q�6P   $	 180Q�6_    65   �� *Status+ 5T      �� 5U      " ��6    .�5V      ��  � ��$
 Wrap=�6G   �� 5W       � ��$
 Left=�6D   6S   �� 5X       � ��$ Stretch=�6B   6T   �� 5Y       �@��TextAlignment$
 Left=�6H   6W   �� 5Z       � ��$ Center=�6L   6]   5[      5]      5`      �� 5c   
   $��Filtruj po wystawiającym��6   $
��Left=�63   $	��Top=�6N   $	��145��6f   $��	10,10,0,0q�6r   �� 5d   
   -   5        $��userNameCombobox��5d      $
��Left=�6+   $	��Top=�6F   $	��250��6^   $��
155,10,0,0q�6j   $��25��6~   6�   �� 5f   
   -   5        $��resetCombobox��5f      $��Pokaż wszystkie polisy��6&   $��426,10,336,665q�6G   6_   �� 5h   
   -   5        $��Exportuj��5h      $
��Left=�6$   $	��Top=�6?   $	��112��6W   $��
10,589,0,0q�6c   $��56��6w   6�   5i      5l      