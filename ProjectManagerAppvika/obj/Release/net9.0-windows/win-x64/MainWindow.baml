   M S B A M L   `   `   `  ����   ProjectManagerApp"    ProjectManagerApp.MainWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$   ��$	��450��$	��900�� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������ .����  �� CornerRadius$ 10�����	#FF252526���	#FF3E3E40$��1q�._�� .+��� ���	#FF1E1E1E J� Opacity$	 0.7Q� J� Effect -  'System.Windows.Media.Effects.BlurEffect     Radius$ 10Q�� $��10q�.+���  �� Orientation$ Vertical=�$
��Left=�$	��Top=�.+��� -   $��AddProjectButton��$��+��   HolographicButton#��[   � ToolTip$# Добавить проект���� -   $��EditProjectButton��$	��✎��#��[  $- 'Редактировать проект��$��0,10,0,0q��� -   $��DeleteProjectButton��$
��🗑��#��[  $! Удалить проект��$��0,10,0,0q��� -   $��RefreshButton��$	��↻��#��[  $+ %Применить изменения��$��0,10,0,0q��� -   $��
ExitButton��$��×��#��[  $ 
Выход��$��0,10,0,0q�&   System.Windows.Controls.DataGrid  -   $��ProjectsDataGrid��$��50,10,10,10q�	   AutoGenerateColumns$	 False��
   
IsReadOnly$

 True��   SelectionMode$ Single=�   SelectionUnit$ FullRow=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    
IsReadOnly$
 True��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $ Дата��$ * $
 True�� �� *Date+  $% Название проекта��$ * $
 True�� �� *ProjectName+  $ Описание��$ * $
 True�� �� *Description+  $ Заголовок��$ * $
 True�� �� *Title+  $ 
Автор��$ * $
 True�� �� *Author+  $	 Git��$ * $
 True�� �� *	GitLink+  $ Комментарий��$ * $
 True�� �� *	Comment+