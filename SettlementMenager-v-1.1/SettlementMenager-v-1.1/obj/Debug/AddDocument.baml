   M S B A M L   `   `   `  ����R  NSettlementMenager-v-1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LocalDatabaseApplicationLocalDatabaseApplication  5   	   *    $LocalDatabaseApplication.AddDocument   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LocalDatabaseApplication     5   	     � Title$  Dodaj polisę��5   	   $	��250��5	   	   $	��350��6    � 
ResizeMode$ CanMinimize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ Normal=�5   	    � Language$ pl-PL�5   	   .��5   
   � $��	0,0,-6,-2q�6   .+�5   
   �� -   5        $��policyNumberTextField��5      $
��Left=�6/   $��23��6J   $��
129,49,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $	��Top=�6   $	��158��6�   �� 5   
   $
��Left=�6   $��	33,49,0,0q�6/   $
��Wrap=�6B   $��Numer polisy��6V   $	��Top=�6j   $��91��6�   $��23��6�   �� 5   
   -   5         ��Name$ brokerNameTextField��5      $
��Left=�6/   $��23��6J   $��129,120,0,0q�6V   $
 Wrap=�6k   $	��Top=�6�   $	��158��6�   �� 5   
   $
��Left=�6   $��
33,120,0,0q�6/   $
��Wrap=�6C   $��
Pośrednik��6W   $	��Top=�6h   $��91��6�   $��23��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��addDate��5      $
��Left=�6$   $	��Top=�6?   $��
129,84,0,0q�6W   $	��158��6k   �� 5   
   $
��Left=�6   $��	33,84,0,0q�6/   $
��Wrap=�6B   $
��Data��6V   $	��Top=�6b   $��91��6z   $��23��6�   �� 5!   
   -   5        $��Dodaj��5!      $
��Left=�6!   $��123,166,0,0q�6<   $	��Top=�6Q   $��84��6i   $��35��6t    �� 	IsDefault . 6�   �� 5$   
   -   5        $��	Wyczyść��5$      $
��Left=�6#   $��
33,166,0,0q�6>   $	��Top=�6R   $��85��6j   $��35��6u    J� RenderTransformOrigin$ 0.535,0.834&�6�   �� 5'   
   -   5        $��Zamknij��5'      $
��Left=�6#   $��212,166,0,0q�6>   $	��Top=�6S   $��75��6k   $��35��6v   $ 0.208,0.447&�6�   5)      5*      