   M S B A M L   `   `   `  ����D  @Pract5WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Pract5WPF.ViewPract5WPF.View  5   	   !    Pract5WPF.View.Registration   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Pract5WPF.View     5   	     � Title$  Registration��5   	   $	��450��6   $	��500��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��2.5* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ Start_image��5      $��Images/back_start2.jpg��5      $
��Fill=�5      $��2��5      $��5��5      �� 5   
   -   5         ��Name$ start_message��5      $��Регистрация��5       $��0��5!      $��2��5"      $��Center=�5#      $��Center=�5$      $��54(�5%      $��Italic$�5&      $��Heavy"�5'      ���	#FFB00C90$��Impact)�67   �� 5)   
   -   5        $ login_textblock��5*      $��
Логин��5+      $��1��5,      $��0��5-      $��Center=�5.      $��Center=�5/      $��55(�50      $��Italic$�51      $��Heavy"�52      ���	#FF1C9FD4$��Franklin Gothic Heavy)�67   
������ 53      �� 55   
   -   5        $ password_textblock��56      $��Пароль��57      $��2��58      $��0��59      $��Center=�5:      $��Center=�5;      $��55(�5<      $��Italic$�5=      $��Heavy"�5>      ���	#FF1C9FD4$��Franklin Gothic Heavy)�67   
������ 5?      �� 5A   
   -   5        $ balance_textblock��5B      $��Баланс��5C      $��3��5D      $��0��5E      $��Center=�5F      $��Center=�5G      $��55(�5H      $��Italic$�5I      $��Heavy"�5J      ���	#FF1C9FD4$��Franklin Gothic Heavy)�67   
������ 5K      �� 5M   
   -   5         ��Name$ registration_button��5N      $��4��5O      $��0��5P      $��10q�5Q      $*��$Зарегестрироваться��5R      $��22(�5S      $��Italic$�5T      $��Heavy"�5U      ���	#FF1C9FD4$��Franklin Gothic Heavy)�5W      
������ 
������ ��5Z      �� *RegistrationToCasic+�� 5\   
   -   5        $ exit_button��5]      $��4��5^      $��1��5_      $��10q�5`      $��
Выйти��5a      $��45(�5b      $��Italic$�5c      $��Heavy"�5d      ���	#FF1C9FD4$��Franklin Gothic Heavy)�5f      
������ 
������ 5h   '   �� 5k   
   -   5         ��Name$ login_textbox��5l      $��1��5m      $��1��5n      $��10q�5o       �� TextAlignment$ Center=�5p      
������ 
�������$��20(�5s      $��Franklin Gothic Heavy)�5t      
������ ��5v      �� *Login+ �� Mode$ TwoWay=��� 5x   
   -	   5        $ password_textbox��5y      $��2��5z      $��1��5{      $��10q�5|      $ Center=�5}      
������ 
�������$��20(�5�      $��Franklin Gothic Heavy)�5�      
������ ��5�      �� *
Password+$ TwoWay=��� 5�   
   -
   5        $ balance_textbox��5�      $��3��5�      $��1��5�      $��10q�5�      $ Center=�5�      
������ 
�������$��20(�5�      $��Franklin Gothic Heavy)�5�      
������ ��5�      �� *	Balance+$ TwoWay=�5�      5�      