   M S B A M L   `   `   `  ���� A  =Tetris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TetrisTetris      Tetris.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:Tetris     -     � WindowStartupLocation$  CenterScreen=� � Title$ Tetris��$	��625��$	��800��$	��675��$	��600��
�������$��IBM Plex Mono)�$��24(�.��� $��	-4,0,4,-6q� � RowDefinitions �� $
��auto ��� $��* � � ColumnDefinitions �� $��* ��� $
��auto ��� $��* �����  �� Color$ Black��.+�(� $��1��$��1��$��0, 30, 0, 30q�.���� -    ��Name$ 
GameCanvas��$	��250��$	��510��$
}�True���� $��1��$��0��$��Center=�$��Center=�.+��� -    ��Name$ 	UserBoard��$��0��$��0��$��User: ��
��� ���$��0, 50q� �� TextAlignment$ center=��� -   $ 	ScoreText��$��0��$��0��$��Score��$��0, 50q�$ center=��� $
��Hold��$ Center=��� -    ��Name$ 	HoldImage��$��10q�$	��125���� $��1��$��2��$	��Top=�$��Center=�$��0,30,0,0q�.+��� $��Ranking��
���  ��$ Center=��� -   $ ScoreRankingBoard��$�� ��
����� �$��13(�$ Center=��� $��1��$��2��$	��Top=�$��Center=�$��	0,431,0,0q�.+��� $��Next Tetromino��$ Center=��� -   $ 	NextImage��$��20q�$	��125��� -   	 �Name$	 GameOverMenu�����	#CC000000$��2��$��3��$y�Hidden=�.+��� $��Center=�$��Center=�.+��� $��	Game Over��$��48(�$ Center=��� -	   $ FinalScoreText��$��Score: ��$��36(�$ Center=��� -
   $��
Play Again��
��� ���$��0, 20, 0, 0q�$��5q��� -   $
��Home��$��Center=�$��54��$��0,30,0,0q�$��2��$	��Top=�$	��121��
������
�������
���   �