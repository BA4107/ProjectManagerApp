   M S B A M L   `   `   `  ����S  OProject Management App 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Project_Management_App_2.Pop_ups Project_Management_App_2.Pop_ups  5   	   6    0Project_Management_App_2.Pop_ups.Edit_Task_Popup   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Project_Management_App_2.Pop_ups     5   	   $	��250��5   	   $	��500��6     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency . .��5      �� ���#472D30 �� CornerRadius$ 15��6"   ._�5   
   � $��10q�6    � RowDefinitions 5      �� 5      $��2* �6    �� 5      $��2* �6    �� 5      $
��0.5* �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��3.5* �6#   .+�5      �� $��0��6   $��0��6(   $
��Name��5      
�������$��	Yu Gothic)�63   $��20(�6J   $��Center=�5      $��Center=�6/   �� 5      -   5         ��Name$ txtEditTaskName��5   3   $��1��6   $��0��6&   $��0 0 30 0q�5      $��30��6$   ��60   Z� �� 5       $��0��6   $��1��6(   $��Description��5!      
�������$��	Yu Gothic)�6:   $��20(�6Q   $��Center=�5"      $��Center=�6/   �� 5#      -   5        $ txtEditTaskDescription��5#   3   $��1��6   $��1��6&   $��0 0 30 0q�5$      $��45��6$   ��60   Z� �� 5&      -   5         ��Name$ btnChange_TaskDetails��5&      $��1��64   $��3��6D   $��Change��5'      
����������#E26D5C���#E26D5C$��	Yu Gothic)�6`   $��16(�5(   5   $
��Left=�5)      $	��Top=�6-   $��88��6E   $��	285,0,0,0q�6P   $��41��6c   �� 5*      -   5        $ btnCancelPopup��5*      $��1��6-   $��3��6=   $��Cancel��5+      
����������#E26D5C���#E26D5C$��	Yu Gothic)�6`   $��16(�5,   .   $
��Left=�5-      $	��Top=�6,   $��88��6D   $��	192,0,0,0q�6O   $��41��6b   5.      5/      50      