   M S B A M L   `   `   `  ����  ProjectManagerApp"    ProjectManagerApp.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$   ��5   	   $	��450��6   $	��900��6     � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��6   
������ .��5      ��  �� CornerRadius$ 10��6   ���	#FF252526���	#FF3E3E40$��1q�6N   ._�5	   
   � .+�5
      �� ���	#FF1E1E1E J� Opacity$	 0.7Q�6,    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 10Q�6!   5      � 5      $��10q�6   .+�5      ��  �� Orientation$ Vertical=�6   $
��Left=�64   $	��Top=�6O   .+�5      �� -   5        $��AddProjectButton��5      $��+��65      HolographicButton#��[  5       � ToolTip$# Добавить проект��5   <   �� 5      -   5        $��EditProjectButton��5      $	��✎��66   #��[  5      $- 'Редактировать проект��5   ?   $��0,10,0,0q�5      �� 5      -   5        $��DeleteProjectButton��5      $
��🗑��68   #��[  5      $! Удалить проект��5   A   $��0,10,0,0q�5      �� 5!      -   5        $��RefreshButton��5!      $	��↻��62   #��[  5"      $+ %Применить изменения��5#   9   $��0,10,0,0q�5$      �� 5&      -   5        $��
ExitButton��5&      $��×��6/   #��[  5'      $ 
Выход��5(   6   $��0,10,0,0q�5)      5*      &   System.Windows.Controls.DataGrid  5-      -   5        $��ProjectsDataGrid��5-      $��50,10,10,10q�63   	   AutoGenerateColumns$	 False��5.      
   
IsReadOnly$

 True��67      SelectionMode$ Single=�5/         SelectionUnit$ FullRow=�62      Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P      
IsReadOnly$
 True��6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Id+6Z     52      $ Дата��6-   $ * 6T   $
 True��6^    6;   �� *Date+6^     53      $% Название проекта��6-   $ * 6g   $
 True��6q    6G   �� *ProjectName+6q     54      $ Описание��6-   $ * 6_   $
 True��6i    6?   �� *Description+6i     55      $ Заголовок��6-   $ * 6Z   $
 True��6d    6@   �� *Title+6d     56      $ 
Автор��6-   $ * 6W   $
 True��6a    6<   �� *Author+6a     57      $	 Git��6-   $ * 6V   $
 True��6`    6:   �� *	GitLink+6`     58      $ Комментарий��6-   $ * 6^   $
 True��6h    6B   �� *	Comment+6h   5:      5;      5<      5=      5>      