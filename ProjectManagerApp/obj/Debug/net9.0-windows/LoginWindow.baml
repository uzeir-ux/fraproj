   M S B A M L   `   `   `  ����  ProjectManagerApp#    ProjectManagerApp.LoginWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$   ��5   	   $	��350��6   $	��400��6     � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��6   
������  � WindowStartupLocation$ CenterScreen=�5   "   .��5      ��  �� CornerRadius$ 15��6   ���	#FF222222���	#FF555555$��1q�6N   ._�5	   
   � .+�5
      �� $ 15��6    J� Opacity$	 0.8Q�6'   ���	#FF111111 J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 5Q�6!   5      �� 5      $��Center=�6   $��Center=�64   $	��300��6Q   .+�5      �� $$��Доступ к системе��6   ���	#FF00FFAA$��18(�6K   $
��Bold"�6Y   $��Center=�5      $��0,0,0,20q�69    � Triggers 5      :� 5      	 :� RoutedEvent$	 Loaded��6'   .[�5      �� .��5   "   �� .��5   &   W� 
 �� TargetProperty$
 Opacity�66    W� From 05   6   	 W� To 16?    g� Duration$ 0:0:1.5D�6F   �� 5   &   $
 Foreground.Color�65    �� From 	#FF0000005   5   	 �� To 	#FF00FFAA6F   $ 0:0:2D�5   5    g� AutoReverse$
 True��6F    g� RepeatBehavior$ Forever��6Y   5   #   5      5      5       G� 5"      -   5        $��PasswordBox��5"      $
��0,10q�61      StealthPasswordBox#��[  5#      �� 5%      -   5        $��ShowPasswordButton��5%      $��Показать��63   $
��0,10q�5&      $	��100��6'   $��Right=�63     HolographicButton#��[ 5'      5(      �� 5*      -   5        $��LoginButton��5*      $��Вход��6,   $
��0,20q�6;   #��[ 5+      6D   5,      5-      5.      5/      