   M S B A M L   `   `   `  ����S  OProject Management App 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Project_Management_App_2.Windows Project_Management_App_2.Windows  5   	   U/clr-namespace:Project_Management_App_2.Controls!Project_Management_App_2.Controls  6F   6    0Project_Management_App_2.Windows.Starting_Screen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Project_Management_App_2.Windows     5   	   >uc/clr-namespace:Project_Management_App_2.Controls     6F   $	��600��5   	   $	��920��6     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency . .��5      �� ���#472D30 �� CornerRadius$ 15��6"   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��4* �6#    � RowDefinitions 5      �� 5      $
��0.5* �6    �� 5      $
��0.7* �6    �� 5      $
��8.5* �6    .+�5      �� -   5         ��Name$ CloseApp��5      $��X��6'   
������ $��0q�5   .   $��
695,0,10,0q�6B   $��1��6V   ���#E26D5C$��	Yu Gothic)�6{   $
��Bold"�6�   $��20(�6�   6�   �� 5      -   5        $ MinimizeApp��5      $��-��6*   
������ $��0q�5   .   $��1��6C   
�������$��	Yu Gothic)�6f   $
��Bold"�6}   $��24(�6�   $��
646,0,46,0q�6�   6�   �� 5       $��1��6   $��Project Manager��6%   $��Center=�5!      $��Center=�63   
�������$��20(�6c   $
��Bold"�6q   $��	Yu Gothic)�6�   �� 5"      $��2��6   $
��0 10q�6&   .+�5#      �� -   5        $ btnAddProject��5#      $��Add new project +��60   ���#E26D5C$��0q�5$   .   
������ $��18(�6[   $��	Yu Gothic)�6i   $
��Bold"�6�   6�   �� 5%      -   5        $ 	AllButton��5%      $��All Projects��6,   $��50��5&      
�������$��18(�68   $
��Bold"�6F   $��	Yu Gothic)�6X   
������ $��0q�5'   2   6F   �� 5(      -   5        $ ActiveButton��5(      $��Active��6/   $��50��5)      
�������$��18(�68   $��	Yu Gothic)�6F   
������ $��0q�5*   2   6F   �� 5+      -   5        $ StalledButton��5+      $��Stalled��60   $��50��5,      
�������$��18(�68   $��	Yu Gothic)�6F   
������ $��0q�5-   2   6F   �� 5.      -   5        $ FinishedButton��5.      $��Finished��61   $��50��5/      
�������$��18(�68   $��	Yu Gothic)�6F   
������ $��0q�50   2   6F   51      �� 53      -   5         ��Name$ projectsListView��53   4   $��2��6   $��1��6$   $��
10 10 10 0q�54      ���	#FFAEB08B
������ 
������ ��55      �� 56      .R�57      7   1Project_Management_App_2.Controls.Project_Control     Project 6-   �� 58      5;      5<      5>      5?      