   M S B A M L   `   `   `  ����R  NSettlementMenager-v-1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LocalDatabaseApplicationLocalDatabaseApplication  5   	   )    #LocalDatabaseApplication.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LocalDatabaseApplication     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ Okno logowania��5	   	   $	��250��6    $	��350��6-    � WindowState$ Normal=�69    � Language$ pl-PL�6N    � WindowStartupLocation$ CenterScreen=�6_   .��5      (� .��5   
   � $	��342��6   .+�5      �� $
��Left=�6   $��	21,31,0,0q�63   $
��Wrap=�6F   $	��Top=�6Z   $��71��6r   �� 6~   $�
Użytkwnik��6�   �� 6�   �� 6�   6�   �� 5      -   5        $��nameData��5      $
��Left=�6(   $��	92,31,0,0q�6C   $	��Top=�6V   $	��214��6n   �� 5      $
��Left=�6   $��	21,70,0,0q�63   $
��Wrap=�6F   $	��Top=�6Z   $��71��6r   �� 6~   $�Hasło��6�   �� 6�   �� 6�   6�   G� 5      -   5        $��passwordField��5   ,    G� PasswordChar$ *��6   $
��Left=�6A   $��23��6\   $��	92,68,0,0q�6h   $	��Top=�6|   $	��214��6�   �� 5      -   5        $��loginButton��5      
��� � �$��Zaloguj��6;   $
��Left=�6M   $��231,116,0,0q�6h   $	��Top=�6}   $��75��6�   $��36��6�    �� 	IsDefault . 6�   �� 5      -   5        $��addUserButton��5      
��� � �$��+��6=   $
��Left=�6I   $��Center=�6d   $��Center=�6�   $��40��6�   $��40��6�   $��92,116,0,64q�6�   $��22(�6�   $
��Bold"�6�   6�   �� 5      -   5        $��removeUserButton��5      
���  ��$��-��6>   $
��Left=�6J   $��Center=�6e   $��Center=�6�   $��40��6�   $��40��6�   $��137,116,0,64q�6�   $��22(�6�   $
��Bold"�6�   6�   �� 5!      -   5        $��connectionSetupButton��5!      $��235,170,36,14q�62   
������ $��36��6b   .��5"      �� $��31��6   $��56��6)   .+�5#      �� $#��Resources\connection-icon.png��6   $��55��6C   $��29��6N   $��0,0,1,0q�6Z   5$      5%      �� 5&      $��Ustawienia połączenia��6   $
��Left=�64   $	��Top=�6O   $��221,200,0,-0.2q�6g   $	��103��6   $��9(�6�   $��21��6�   5(      5)      5*      