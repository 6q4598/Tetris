   M S B A M L   `   `   `  ����A  =Tetris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TetrisTetris  5   	       Tetris.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Tetris     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Tetris��5	   	   $	��625��6   $	��800��6%   $	��675��5
   	   $	��600��6   
�������$��IBM Plex Mono)�5   	   $��24(�6&   .��5      � $��	-4,0,4,-6q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   ��5    
   �� 5"       �� Color$ Black��6   .+�5&   
   (� $��1��6   $��1��5'      $��0, 30, 0, 30q�5(      .��5*      �� -   5         ��Name$ 
GameCanvas��5*      $	��250��5+      $	��510��5,      $
}�True��5-      5.      50      �� 52   
   $��1��6   $��0��53      $��Center=�54      $��Center=�55      .+�57      �� -   5         ��Name$ 	UserBoard��57      $��0��58      $��0��59      $��User: ��5:      
��� ���$��0, 50q�5<       �� TextAlignment$ center=�5=      �� 5@      -   5        $ 	ScoreText��5@      $��0��5A      $��0��5B      $��Score��5C      $��0, 50q�5D      $ center=�5E      �� 5H      $
��Hold��6   $ Center=�5I      �� 5K      -   5         ��Name$ 	HoldImage��5K      $��10q�5L      $	��125��5M      5O      �� 5Q   
   $��1��5R      $��2��5S      $	��Top=�5T      $��Center=�5U      $��0,30,0,0q�64   .+�5W      �� $��Ranking��6   
���  ��$ Center=�5Y      �� 5[      -   5        $ ScoreRankingBoard��5[      $�� ��5\      
����� �$��13(�5^      $ Center=�5_      5a      �� 5c   
   $��1��6   $��2��5d      $	��Top=�5e      $��Center=�5f      $��	0,431,0,0q�64   .+�5h      �� $��Next Tetromino��6   $ Center=�5i      �� 5k      -   5        $ 	NextImage��5k      $��20q�5l      $	��125��5m      5o      � 5q   
   -   5        	 �Name$	 GameOverMenu��5q      ���	#CC000000$��2��5s      $��3��5t      $y�Hidden=�5u      .+�5w      �� $��Center=�6   $��Center=�5x      .+�5z      �� $��	Game Over��6   $��48(�5{      $ Center=�5|      �� 5~      -	   5        $ FinalScoreText��5~      $��Score: ��5      $��36(�5�      $ Center=�5�      �� 5�      -
   5        $��
Play Again��5�      
��� ���$��0, 20, 0, 0q�5�      $��5q�5�      5�      5�      5�      �� 5�   
   -   5        $
��Home��5�      $��Center=�5�      $��54��5�      $��0,30,0,0q�5�      $��2��5�      $	��Top=�5�      $	��121��5�      
������
�������
���   �6Z   5�      5�      