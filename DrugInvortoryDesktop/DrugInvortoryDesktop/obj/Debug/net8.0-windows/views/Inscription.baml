   M S B A M L   `   `   `  ����O  KDrugInvortoryDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:DrugInvortoryDesktop.ControlUtilisatuer'DrugInvortoryDesktop.ControlUtilisatuer  5   	   ,    &DrugInvortoryDesktop.views.Inscription   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Duc5clr-namespace:DrugInvortoryDesktop.ControlUtilisatuer     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   69     � Title$  Accueil��5	   	   $	��720��6   $
��1080��6&    � WindowStartupLocation$ CenterScreen=�63    � WindowStyle$
 None=�6X    � AllowsTransparency$
 True��6k   
������ .��5      �� -   5        
������� �� CornerRadius$ 20��5   "   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��350��6#   �� 5      $��* �6#   .+�5      �� 
���   � �� Padding$ 20q�6(   $ 	20 0 0 20��65   ._�5      ��  �� Orientation$ Vertical=�6   $	��Top=�64   .+�5      �� $��/images/logoCannabis.jpg��6   �� 5      $9��3Bienvenue sur la page d'inscristion de DRUGVENTORY.��6     �� TextAlignment$ Center=�6[   $��35(�6s   $
��auto��6�   $
��Wrap=�6�   $��CharacterEllipsis=�5      $
��Bold"�67   
�������$��	0 20 0 20q�6\   5      5      �� 5      -   5        $��1��5      
�������$ 10q�68   $ 	0 25 25 0��6E   ._�5       � .+�5!      �� -   5        $��/images/closelogo.jpg��5!         inscripIcons#��[  6;   $��25��6a   $��	0,4,5,657q�6l   $��Stretch=�6   6�   �� 5"      -   5        $��/images/minimizelogo.jpeg��5"      #��[  6@   $��25��6f   $��0 7 40 0q�6q   6�   � 5#      $��Center=�6   $��Center=�68   $��0 10 0 0q�6S    5$      �� 5%      $	��150 �6/   �� 5&      $��* �6/   	 � RowDefinitions	 5(      �� 5)      $
��auto �6,   �� 5*      $
��auto �6,   �� 5+      $
��auto �6,   �� 5,      $
��auto �6,   �� 5-      $
��auto �6,   �� 5.      $
��auto �6,   �� 5/      $
��auto �6,   .+�54      ��   text#��[ 6$   $��0��6C   $	��Nom��6P   �� 55      #��[ 6$   $��1��6C   $��Prenom��6P   �� 56      #��[ 6$   $��2��6C   $��	Naissance��6P   $
��Wrap=�6a   $��CharacterEllipsis=�57      �� 58      #��[ 6$   $��3��6C   $��Email��6P   �� 59      #��[ 6$   $��4��6C   $	��Tel��6P   �� 5:      #��[ 6$   $��5��6C   $��Domicile��6P   7   1DrugInvortoryDesktop.ControlUtilisatuer.MyTextBox  5;      $��0��6'   $��1��64   
   Hint$

 Oury��6D     5<      $��1��6'   $��1��64   $

 Oury��6D     5=      $��2��6'   $��1��64   $

 Oury��6D     5>      $��3��6'   $��1��64   $

 Oury��6D     5?      $��4��6'   $��1��64   $

 Oury��6D     5@      $��5��6'   $��1��64   $

 Oury��6D   � 5C      $��6��6   $��1��6,   $��0 40 0 0q�6<    5D      �� 5E   "   $��* �63   �� 5F   "   $��* �63   .+�5I      �� -   5          
AnnulerBtn#��[ 5I   %   $��Annuler��6J   $��0 0 10 0q�6\   6n   �� 5J        EnregistrerBtn#��[ 6%   $��Enregistrer��6M   $��10 0 0 0q�6c   $��1��6u   5L      5M      5N      5Q      5S      5T      5U      