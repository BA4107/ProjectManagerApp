   M S B A M L   `   `   `  ����S  OProject Management App 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Project_Management_App_2.Windows Project_Management_App_2.Windows  5   	   9    3Project_Management_App_2.Windows.Add_Project_Screen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Project_Management_App_2.Windows     5   	   $	��500��5   	   $	��820��6     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency . .��5      �� ���#472D30 �� CornerRadius$ 15��6"   ._�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��6* �6    .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $	��10* �6'   .+�5      �� -   5         ��Name$ btnBack_Projects��5   )   $��0��6   $��<��6C   
������ 
������ 
�������$��40(�5      $��	Yu Gothic)�6#   6:   �� 5      $��1��6   $��New Project��6,   
������ 
������� �� Padding$ 
10 10 10 0q�5   D   $��40(�5       $��	Yu Gothic)�6&   $��Center=�6=   5!      � 5#      $��1��6   $��20q�6    ���	#FFAEB08B 5$      �� 5%      $��6* �6$   �� 5&      $��* �6$   .+�5)      � $��0��6    5*      �� 5+      $
��1.5* �6+   �� 5,      $��5* �6+    5.      �� 5/      $��* �6(   �� 50      $��* �6(   �� 51      $��* �6(   �� 52      $��* �6(   .+�55      �� $��0��6    $��0��6-   $
��Name��6=   $��Center=�56      $��Center=�63   
�������$��	Yu Gothic)�58      $��30(�6/   �� 59      -   5         ��Name$ txtProjectName��59   ;   $��0��6   $��1��6+   $��40��5:      $��0 0 30 0q�6"   
�������64   �� 5<      $��1��6    $��0��6-   $��Starting Date��6=   $��Center=�5=      $��Center=�63   
�������$��	Yu Gothic)�5?      $��30(�6/   (  "System.Windows.Controls.DatePicker  5@      -   5        	  Name$	 txtProjectStartDate��5@   >   $��1��6!   $��1��6.   $��30��5A      $��0 0 30 0q�6"   �� 5C      $��2��6    $��0��6-   $��Deadline��6=   $��Center=�5D      $��Center=�63   
�������$��	Yu Gothic)�5F      $��30(�6/   � 5G      $��2��6   $��1��6(    5H      �� 5I      $
��0.9* �6/   �� 5J      $
��0.1* �6/   .+�5L        -   5        $	 txtProjectDeadline��5L   5   $��0��6%   $��30��5M      �� 5N      -   5        $ btnNoDeadline��5N   1   $��1��6!   $��X��6H   $��10,32,33,33q�5O      
����������#E26D5C���#E26D5C5P   W   5Q      �� 5S      $��3��6    $��0��6-   $��Description��6=   $��Center=�5T      $��Center=�63   
�������$��	Yu Gothic)�5V      $��30(�6/   �� 5W      -   5        $ txtProjectDescription��5W   ;   $��3��6   $��1��6+   $��60��5X      $��0 0 30 0q�6"   
�������64   5Y      � 5[      $��1��6   .+�5\      �� -   5        $ btnSaveProject��5\      $
��Save��65   $��100 5q�6D   
����������#E26D5C���#E26D5C$��25(�5^      $��	Yu Gothic)�6   66   5_      5`      5a      5b      5c      