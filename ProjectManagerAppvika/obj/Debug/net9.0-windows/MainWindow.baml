   M S B A M L   `   `   `  ����  ProjectManagerApp"    ProjectManagerApp.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Главное меню��5   	   $	��400��6   $	��900��6+   .��5      � .+�5   
   �� -   5        $��AddProjectButton��5      $#��Добавить запись��6)   $	��Top=�6C   $
��Left=�6[   $��	10,10,0,0q�6v   $	��150��6�   $��40��6�   
��� ���6�   �� 5   
   -   5        $��
ExitButton��5      $��
Выход��6#   $	��Top=�63   $
��Left=�6K   $��	10,60,0,0q�6f   $	��150��6y   $��40��6�   
���  ��6�   �� 5	   
   -   5        $��RefreshButton��5	      $��Обновить��6&   $	��Top=�69   $
��Left=�6Q   $��
10,110,0,0q�6l   $	��150��6�   $��40��6�   
��� � �6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��ProjectsDataGrid��5      $��200,10,10,10q�6+      AutoGenerateColumns$ False��6A      
IsReadOnly$
 True��6]      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $ Дата��6%   $ * 6L    63   �� *Date+6L     5      $% Название проекта��6%   $ * 6_    6?   �� *ProjectName+6_     5      $ Описание��6%   $ * 6W    67   �� *Description+6W     5      $ Заголовок��6%   $ * 6R    68   �� *Title+6R     5      $ 
Автор��6%   $ * 6O    64   �� *Author+6O     5      $	 Git��6%   $ * 6N    62   �� *	GitLink+6N     5      $ Комментарий��6%   $ * 6V    6:   �� *	Comment+6V   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Действия��6)   $	 200 6;      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� -   5        $ ��Редактировать��5   )   $��80��6A   $��5q�6L   6W   �� 5   "   -   5        $��Удалить��5   )   $��80��6;   $��5q�6F   6Q   5       5!      5#      5%      5&      5'      