   M S B A M L   `   `   `  ����S  OProject Management App 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Project_Management_App_2.Windows Project_Management_App_2.Windows  5   	   6    0Project_Management_App_2.Windows.Add_Task_Screen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Project_Management_App_2.Windows     5   	   $	��400��5   	   $	��820��6     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency . .��5      �� ���#472D30 �� CornerRadius$ 15��6"   ._�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��6* �6    .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $	��10* �6'   .+�5      �� -   5         ��Name$ btnBack_CurrentProjects��5   )   $��0��6   $��<��6J   
������ 
������ 
�������$��40(�5      $��	Yu Gothic)�6#   6:   �� 5      $��1��6   $��New Task��6,   
������ 
������� �� Padding$ 
10 10 10 0q�5   D   $��40(�5      $��	Yu Gothic)�6&   $��Center=�6=   5       � 5"      $��1��6   $��20q�6    ���	#FFAEB08B 5#      �� 5$      $��3* �6$   �� 5%      $��* �6$   .+�5(      � $��0��6    5)      �� 5*      $
��1.5* �6+   �� 5+      $��5* �6+    5-      �� 5.      $��* �6(   �� 5/      $��* �6(   .+�52      �� $��0��6    $��0��6-   $
��Name��6=   $��Center=�53      $��Center=�63   
�������$��	Yu Gothic)�55      $��30(�6/   �� 56      -   5         ��Name$ txtTaskName��56   ;   $��0��6   $��1��6+   $��40��57      $��0 0 30 0q�6"   
�������64   �� 59      $��1��6    $��0��6-   $��Description��6=   $��Center=�5:      $��Center=�63   
�������$��	Yu Gothic)�5<      $��30(�6/   �� 5=      -   5        $ txtTaskDescription��5=   ;   $��1��6   $��1��6+   $��60��5>      $��0 0 30 0q�6"   
�������64   5?      � 5@      $��1��6   .+�5A      �� -   5        $ btnSaveProject��5A      $��3��65   $
��Save��6B   $��100 10q�6Q   
����������#E26D5C���#E26D5C$��25(�5C      $��	Yu Gothic)�6   66   5D      5E      5F      5G      5H      