   M S B A M L   `   `   `  ����   ProjectManagerApp#    ProjectManagerApp.LoginWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$   ��$	��350��$	��400�� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������  � WindowStartupLocation$ CenterScreen=�.����  �� CornerRadius$ 15�����	#FF222222���	#FF555555$��1q�._�� .+��� $ 15�� J� Opacity$	 0.8Q����	#FF111111 J� Effect -  'System.Windows.Media.Effects.BlurEffect     Radius$ 5Q��� $��Center=�$��Center=�$	��300��.+��� $$��Доступ к системе�����	#FF00FFAA$��18(�$
��Bold"�$��Center=�$��0,0,0,20q� � Triggers :� 	 :� RoutedEvent$	 Loaded��.[��� .���� .��W� 
 �� TargetProperty$
 Opacity� W� From 0	 W� To 1 g� Duration$ 0:0:1.5D��� $
 Foreground.Color� �� From 	#FF000000	 �� To 	#FF00FFAA$ 0:0:2D� g� AutoReverse$
 True�� g� RepeatBehavior$ Forever��G� -   $��PasswordBox��$
��0,10q�   StealthPasswordBox#��[  �� -   $��ShowPasswordButton��$��Показать��$
��0,10q�$	��100��$��Right=�  HolographicButton#��[ �� -   $��LoginButton��$��Вход��$
��0,20q�#��[ 