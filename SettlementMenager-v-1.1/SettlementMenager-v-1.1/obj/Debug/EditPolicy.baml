   M S B A M L   `   `   `  ����R  NSettlementMenager-v-1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LocalDatabaseApplicationLocalDatabaseApplication  5   	   1    +LocalDatabaseApplication.EditPolicyDocument   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LocalDatabaseApplication     5   	     � Title$  Edytuj polisę��5   	   $	��250��5	   	   $	��550��5
   	    � 
ResizeMode$ CanMinimize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ Normal=�5   	    � Language$ pl-PL�5   	   .��5      � $��0,0,4,-6q�6   .+�5   
   �� $ ��Bieżąca polisa w edycji:��6   $
��Left=�63   $	��Top=�6N   $��	347,4,0,0q�6f   $	��183��6y   $��26��6�   $��Center=�6�   �� 5   
   -   5         ��Name$ policyNumberTextField��5      $
��Left=�61   $��23��6L   $��
128,30,0,0q�6X    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��158��6�   �� 5   
   $
��Left=�6   $��	32,30,0,0q�6/   $
��Wrap=�6B   $��Numer polisy��6V   $	��Top=�6j   $��91��6�   $��23��6�   �� 5   
   -   5         ��Name$ policyDataLabel��5      $
��Left=�6)   $	��Top=�6D   $��
347,30,0,0q�6\   $	��183��6p   $��23��6|   $��Right=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ editDate��5      $
��Left=�6'   $��
128,69,0,0q�6B   $	��Top=�6V   $	��158��6n   �� 5   
   $
��Left=�6   $��	32,69,0,0q�6/   $
��Wrap=�6B   $
��Data��6V   $	��Top=�6b   $��91��6z   $��23��6�   �� 5   
   -   5        $ 
dateToEdit��5      $
��Left=�6$   $	��Top=�6?   $��
347,70,0,0q�6W   $	��183��6k   $��23��6w   $��Right=�6�   �� 5"   
   -   5        	 ��Name$	 userComboboxField��5"      $
��Left=�6.   $	��Top=�6I   $	��158��6a   $��128,106,0,0q�6m   �� 5#   
   $
��Left=�6   $��
32,106,0,0q�6/   $
��Wrap=�6C   $��Wystawiający��6W   $	��Top=�6k   $��91��6�   $��23��6�   �� 5$   
   -   5        $ userDataLabel��5$      $
��Left=�6'   $	��Top=�6B   $��347,106,0,0q�6Z   $	��183��6o   $��32��6{   $��Right=�6�   �� 5&   
   -   5        $ brokerNameTextField��5&      $
��Left=�6/   $��23��6J   $��128,143,0,0q�6V   $
 Wrap=�6k   $	��Top=�6�   $	��158��6�   �� 5'   
   $
��Left=�6   $��
32,143,0,0q�6/   $
��Wrap=�6C   $��
Pośrednik��6W   $	��Top=�6h   $��91��6�   $��23��6�   �� 5(   
   -   5        $ brokerNameLabel��5(      $
��Left=�6)   $	��Top=�6D   $��347,143,0,0q�6\   $	��183��6q   $��23��6}   $��Right=�6�   �� 5-   
   -	   5        $��Zapisz��5-      $
��Left=�6"   $��128,184,0,0q�6=   $	��Top=�6R   $	��158��6j   $��21��6v   
 J� RenderTransformOrigin$
 0.517,0.909&�6�    �� 	IsDefault . 
��� � �6�   5/      50      