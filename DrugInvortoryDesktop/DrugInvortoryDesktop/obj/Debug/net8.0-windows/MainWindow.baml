   M S B A M L   `   `   `  ����O  KDrugInvortoryDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DrugInvortoryDesktopDrugInvortoryDesktop  5   	   %    DrugInvortoryDesktop.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:DrugInvortoryDesktop     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Drug Inventory Desktop��5   	   $	��720��6(   $
��1080��65    � WindowStyle$
 None=�6B    � AllowsTransparency$
 True��6U   
�������.��5      �� ._�5   
   �  � ColumnDefinitions 5      �� 5      -   5         ��Name$ imagePageConnexion��5   -   $��* �6#   5      �� 5      -   5        $ formConnexion��5   /   $	��.9* �6#   5      .+�5      �� -   5         ��Name$ ConnexionGauche��5       �� CornerRadius$ 	10 0 0 10��6.   ._�5      � .+�5      �� $��0��6   $��2��6+   $��0��6<   $��/Marijuana-1.jpg��6N   $
��Left=�6h   $	��Top=�6�   $
��Fill=�6�   5      5      �� 5!      -   5         ��Name$ connexionDroite��5!      	 �� Orientation$	 Vertical=�62   $��0��6I   $��2��6V   $��1��6g   $��0,10,0,0q�6w   .+�5"      �� -   5        
 �� TextWrapping$

 Wrap=�5"      $��WELCOME��6.   $	��210��6=   $��43��6k   $��	-3,30,1,1q�6w   $��Center=�6�   $��24(�6�   
�������6�   ]� 5#      .+�5$      �� $��Email:��6   $��10,10,10,10q�6.   $��82��6C   �� 5%      $

 Wrap=�6   $	��266��63   $��29��6@   $��10,10,10,10q�6L   5&      ]� 5(      .+�5)      �� $��Mot de pass:��6   $	��157��63   $��0,20,0,0q�6?   �� 5*      $

 Wrap=�6   $	��219��63   $��34��6@   $��0,20,0,0q�6L   5+      ]� 5,      $��0,30,0,0q�6   .+�5-      �� $��Remember me ��6   $��Arial)�66   $��20(�6I   $
��Bold"�6W   $��5,9,5,5q�6i   �� 5.      -   5         ��Name$ btnForgotPassword��5.      $��Forgot password ?��68   $��16(�6T   $��Arial)�6b   ���	#FFFCFAFA$��31��6�   $��5,5,5,5q�6�   $	��152��6�   ���	#FFFD971D���	#FFFFFDFD6�   50      �� 51      -   5        $ btnConnexion��51      $��	Connexion��6/   $	��200��6C   $��0,30,0,0q�6O   ���	#FF38CB41$��Californian FB)�6x   $
��Bold"�6�   $��24(�6�   �� 52      -   5        $ 	btnSignUp��52      $��Sign up��6,   $��16(�6>   $��Arial)�6L   ���	#FFFCFAFA$��35��6v   $��5,40,5,5q�6�   $	��126��6�   ���	#FFFD971D���	#FFFFFDFD6�   54      58      59      5;      