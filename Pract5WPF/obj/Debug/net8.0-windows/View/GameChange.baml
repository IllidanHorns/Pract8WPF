   M S B A M L   `   `   `  ����D  @Pract5WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Pract5WPF.ViewPract5WPF.View  5   	       Pract5WPF.View.GameChange   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Pract5WPF.View     5   	     � Title$  
GameChange��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $
��0.5* �6   �� 5      $��3* �6   �� 5      $
��0.8* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Images/back_start2.jpg��5      $��2��5      $��6��5      $
��Fill=�5      �� 5   
   -   5         ��Name$ start_message��5      $��Лучшие игры��5      $��0��5      $��2��5       $��Center=�5!      $��Center=�5"      $��54(�5#      $��Italic$�5$      $��Heavy"�5%      ���	#FFB00C90$��Impact)�67   �� 5'   
   -   5        $ name_of_first_game��5(      $��Дикий запад��5)      $��0��5*      $��1��5+       �� TextAlignment$ Center=�5,       �� Padding$ 5q�5-      $��20(�5.      $��Italic$�5/      $��Heavy"�50      ���	#FF1C9FD4$��Franklin Gothic Heavy)�52      �� 55   
   -   5        $ name_of_second_game��56      $��Угадай число��57      $��1��58      $��1��59      $ Center=�5:      $ 5q�5;      $��20(�5<      $��Italic$�5=      $��Heavy"�5>      ���	#FF1C9FD4$��Franklin Gothic Heavy)�5@      �� 5B   
   -   5         ��Name$ first_game_button��5C      $��0��5D      $��2��5E      
������ .��5G      �� $��Images/old_west1.jpg��6   $��0q�5H      5I      �� 5J   
   -   5        $ second_game_button��5J      $��1��5K      $��2��5L      
������ .��5N      �� $��Images/number1.jpg��6   $��2��64   $��1��6A   5O      �� 5P   
   -   5        $
 exit��5Q      $��2��5R      $��5��5S      
������ $��
Выйти��5U      $��48(�5V      $��Italic$�5W      $��Heavy"�5X      ���	#FFB00C90$��Impact)�67   6K   �� 5[   
   -   5        $ login��5\   
   $��Ваш логин��5]   
   $��0��5^   
   $��3��5_   
   $ Center=�5`   
   $ 5q�5a   
   $��20(�5b   
   $��Italic$�5c   
   $��Heavy"�5d   
   ���	#FF1C9FD4$��Franklin Gothic Heavy)�5f   
   �� 5i   
   -   5        $ balance��5j   
   $��1��5k   
   $��3��5l   
   $ Center=�5m   
   $ 5q�5n   
   $��20(�5o   
   $��Italic$�5p   
   $��Heavy"�5q   
   ���	#FF1C9FD4$��Franklin Gothic Heavy)�5t   
   ��5s      �� *Login+5t   
   5v      5w      