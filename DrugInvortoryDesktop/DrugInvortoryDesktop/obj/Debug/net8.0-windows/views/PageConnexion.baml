   M S B A M L   `   `   `  ����O  KDrugInvortoryDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:DrugInvortoryDesktop.viewsDrugInvortoryDesktop.views  5   	   .    (DrugInvortoryDesktop.views.PageConnexion   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:DrugInvortoryDesktop.views     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Drug Inventory Desktop��5      $	��720��6'   $
��1080��64    � WindowStyle$
 None=�6A    � AllowsTransparency$
 True��6T   
�������.��5
      �� -   5        
������� �� CornerRadius$ 20��5
   !   ._�5   
   �  � ColumnDefinitions 5      �� 5      -   5         ��Name$ imagePageConnexion��5   -   $��* �6#   5      �� 5      -   5        $ formConnexion��5   /   $	��.9* �6#   5      .+�5      �� -   5         ��Name$ ConnexionGauche��5      $ 	10 0 0 10��62   ._�5      � .+�5      �� $��0��6"   $��2��6/   $��0��6@   $��/Marijuana-1.jpg��6R   $
��Left=�6l   $	��Top=�6�   $
��Fill=�6�   �� 5      .+�5      �� $��Drug-Inventory��6(    �� TextAlignment$ Center=�6>   $��Black"�6U   $
��50px(�6i   	 �� Padding$	 10q�6y   
�������6�   5      5      5      � 5      $��1��6   
 � RowDefinitions
 5       �� 5!      $
��auto �6$   �� 5"      $
��auto �6$   �� 5#      $
��auto �6$   �� 5$      $
��auto �6$   �� 5%      $
��auto �6$   �� 5&      $��* �6$   .+�5)      ]� .+�5*      ��  �� TextWrapping$
 Wrap=�6   $��WELCOME��62   $	��210��6A   $��43��6M   $��	-3,30,1,1q�6Y   $��Center=�6l   $��24(�6�   
�������$��0��6�   5+      ]� 5.      $��10,30,30,10q�6   $��1��61   .+�5/      �� $��Email:��6      lblConnexion#��[  6-   �� 50      $
 Wrap=�6     txtbxConnexion#��[ 62   $	��266��6Z   $��29��6i   51      ]� 54      $��10,30,30,10q�6   $��2��61   .+�55      �� $��Mot de passe:��6   #��[  64   �� 56      #��[ 6   $
 Wrap=�6F   $	��219��6Z   $��34��6i   57      ]� 5:      $��10,30,30,10q�6   $��3��61   .+�5;      �� $��Remember me��6   $��Arial)�65   $��20(�6H   $
��Bold"�6V   $��5,9,5,5q�6h   �� 5<      -   5         ��Name$ btnForgotPassword��5<      $��Forgot password?��68   $��16(�6S   $��Arial)�6a   ���	#FFFCFAFA$��31��6�   $��5,5,5,5q�6�   $	��152��6�   ���	#FFFD971D���	#FFFFFDFD6�   5=      ]� 5@      $��4��6   $��	0,40,0,40q�6)   $��Center=�6<   .+�5A      �� -   5        $ btnConnexion��5A        connexionBtn#��[ 63   $��	Connexion��6Y   $	��200��6m   6y   5B      �� 5F      -   5          btnInscription#��[ 5F      $��Bottom=�6B   $��Center=�6]   $��Bottom=�6z   $��5��6�   .��5G      ��  �� Orientation$ 
Horizontal=�6!   .+�5H      �� 
��� � �$��Créer un compte��67   5I      5J      5M      5N      5O      5P      