   M S B A M L   `   `   `  ����S  OProject Management App 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Project_Management_App_2.Pop_ups Project_Management_App_2.Pop_ups  5   	   9    3Project_Management_App_2.Pop_ups.Edit_Project_Popup   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Project_Management_App_2.Pop_ups     5   	   $	��350��5   	   $	��790��6     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency . .��5      �� ���#472D30 �� CornerRadius$ 15��6"   ._�5   
   � $��10q�6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $
��1.5* �6    �� 5      $
��0.5* �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��4* �6#   .+�5      �� $��0��6   $��0��6(   $
��Name��5      
�������$��	Yu Gothic)�63   $��28(�6J   $��Center=�5      $��Center=�60   �� 5      -   5         ��Name$ txtEditProjectName��5   3   $��1��6   $��0��6&   $��35��5       $��0 0 40 0q�6   ��60   Z� �� 5"      $��0��6   $��1��6(   $��Deadline��5#      
�������$��	Yu Gothic)�67   $��28(�6N   $��Center=�5$      $��Center=�60   � 5%      $��1��6   $��1��6     5&      �� 5'      $
��0.9* �6'   �� 5(      $
��0.1* �6'   .+�5*      �� -   5         ��Name$ btnNoDeadline��5*      $��X��60   
�������$��	Yu Gothic)�5+   ,   ���#E26D5C���#E26D5C$��539,10,44,16q�6n   $��18(�6�   $��Center=�6�   $��2��6�   (  "System.Windows.Controls.DatePicker  5,      -   5          Name$ txtEditProjectDeadline��5,   -   $��0��6   $��30��6M   $��
0,12,20,13q�6p   ��6Y   Z� 6p   5-      �� 5/      $��0��6   $��2��6(   $��State��50      
�������$��	Yu Gothic)�64   $��28(�6K   $��Center=�51      $��Center=�60   �� 52      -   5        	 ��Name$	 txtEditProjectState��52   4   $��1��6   $��2��6'   $��30��53      $��0 0 40 0q�65   ��6   Z� .@�54      �� -   5        
 ��Name$
 	cmbActive��54      .��62   Active6:   �� 55      -   5        $
 
cmbStalled��55      .��63   	Stalled6<   �� 56      -   5        $
 cmbFinished��56      .��64   
Finished6>   57      �� 59      $��0��6   $��3��6(   $��Description��5:      
�������$��	Yu Gothic)�6:   $��28(�6Q   $��Center=�5;      $��Center=�60   �� 5<      -   5        $ txtEditProjectDescription��5<   3   $��1��6   $��3��6&   $��45��5=      $��0 0 40 0q�65   ��6   Z� 65   �� 5?      -	   5        $ btnChange_ProjectDetails��5?      $��1��67   $��5��6G   $��Change��5@      
����������#E26D5C���#E26D5C$��	Yu Gothic)�5A      $��25(�6(   $
��Left=�5C      $	��Top=�6,   $	��156��6D   $��	444,0,0,0q�6P   $��55��6c   �� 5D      -
   5        $ btnCancelPopup��5D      $��1��6-   $��5��6=   $��Cancel��5E      
����������#E26D5C���#E26D5C$��	Yu Gothic)�6`   $��25(�6w   $
��Left=�5G      $	��Top=�6,   $	��156��6D   $��	268,0,0,0q�6P   $��55��6c   5H      5I      5J      