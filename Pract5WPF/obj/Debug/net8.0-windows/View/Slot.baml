   M S B A M L   `   `   `  ����D  @Pract5WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pract5WPF	Pract5WPF  5   	       Pract5WPF.View.Slot   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Pract5WPF     5   	     � Title$  Slot1��5   	   $	��450��6   $	��800��6$   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��1.0* �6   �� 5      $��5* �6   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   �� $��Images/wild_west1.jpg��5   	   $��4��5   	   $
��Fill=�5      � 5   
   $��0��6    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��3* �6#   .+�5      �� -   5         ��Name$ balance_message��5      $��Баланс - ��5      $��0��5        �� TextAlignment$ Center=�5!       �� Padding$ 5q�5"      $��35(�5#      $��Italic$�5$      $��Heavy"�5%      
�������$��Franklin Gothic Heavy)�5'      �� 5*      -   5        $ balance_count��5+      $��1��5,      $ Center=�5-      $ 5q�5.      $��35(�5/      $��Italic$�50      $��Heavy"�51      
��� ���$��Franklin Gothic Heavy)�53      ��54      �� *
Balancee+56      � 58   
   $��1��6    59      �� 5:      �� 5;      �� 5<      .+�5>      �� -   5        $ count1��5>      $��0��6(   $��5q�68   $ Center=�6C   $��Center=�6Z   $	��100(�6u   $��Heavy"�6�   
���**����6�   �� *Value1+ �� Mode$ TwoWay=�6�   �� 5?      -   5        $ count2��5?      $��1��6(   $��5q�68   $ Center=�6C   $��Center=�6Z   $	��100(�6u   $��Heavy"�6�   
���**����6�   �� *Value2+$ TwoWay=�6�   �� 5@      -   5        $ count3��5@      $��2��6(   $��5q�68   $ Center=�6C   $��Center=�6Z   $	��100(�6u   $��Heavy"�6�   
���**����6�   �� *Value3+$ TwoWay=�6�   5A      � 5C   
   $��2��6    5D      �� 5E      $��1* �6#   �� 5F      $��1* �6#   �� 5G      $��2* �6#   .+�5I      �� -   5        $ result_of_spin��5I      $��0��60   $��Ура!��6@   $��5q�6L   $��Center=�6W   $��Center=�6r   $��35(�6�   
�������$��Heavy"�6�   $��Franklin Gothic Heavy)�6�   �� 5J      -   5        $ your_result��5J      $��1��6-   $��Ваш выигрыш - ��6=   $��5q�6S   $��Center=�6^   $��Center=�6y   $��24(�6�   
�������$��Heavy"�6�   $��Franklin Gothic Heavy)�6�   �� 5K      -   5        $ result_of_win_count��5K      $��2��65   $��5q�6g   $��Center=�6r   $��Center=�6�   $��48(�6�   
��� ���$��Heavy"�6�   $��Franklin Gothic Heavy)�6�   ��6E   �� *Win+$ TwoWay=�6�   5L      � 5N   
   $��3��6    5O      �� 5P      $
��0.8* �6#   �� 5Q      $��2* �6#   �� 5R      $
��0.8* �6#   �� 5S      $��5* �6#   �� 5T      $
��1.8* �6#   .+�5V      �� -	   5         ��Name$ minus_stavka��5V   %   $��0��6   
������ $��-��6T   $��40(�6`   $��Heavy"�6n   
���������6�   �� *Minus_rate_b+�� 5W      -
   5        $ plus_stavka��5W   %   $��2��6   
������ $��+��6S   $��40(�6_   $��Heavy"�6m   
���������6�   �� *Plus_rate_b+�� 5X      -   5        $ stavka��5Y      $��1��5[      $ Center=�5\      $ 5q�5]      $��30(�5^      $��Italic$�5_      $��Heavy"�5`      
�������$��Franklin Gothic Heavy)�5b      ��5Z      �� *Rate+$ TwoWay=�5b      �� 5d      -   5        $
 exit��5e      $��5��5f      
������ $��
Выйти��5h      $��35(�5i      $��Italic$�5j      $��Heavy"�5k      
�������$��Franklin Gothic Heavy)�6>   6a   �� 5m      -   5        $ 
start_spin��5n      $��3��5o      
������ $��
=Спин=��5q      $��40(�5r      $��Italic$�5s      $��Heavy"�5t      
�������$��Franklin Gothic Heavy)�6>   ��5u      �� *Spin+5w      5x      5y      