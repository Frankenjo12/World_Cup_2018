   M S B A M L   `   `   `  ����B  >Wpf App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Wpf_AppWpf_App  5   	       Wpf_App.TeamOverview   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Wpf_App     5   	     � Title$  TeamOverview��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5        $��
cbFavorite��5
   4   $
��Left=�6F   $��	62,67,0,0q�6a   $	��Top=�6t   $	��184��6�   �� 5   
      lbFavoriteTeam#���   6   $
��Left=�6;   $��
62,102,0,0q�6V   $	��Top=�6j    J� RenderTransformOrigin$ -0.747,0.31&�6�   �� 5   
     lbEnemyTeam#���  6   $��Right=�68   $��
0,102,47,0q�6T   $	��Top=�6h   $ -0.747,0.31&�6�   �� 5   
   -   5        $��lbScore��5        lbScore#���  6   $��30(�6C   $��Center=�6Q   $��0,94,0,0q�6n   $	��Top=�6�   $	��108��6�   $��64��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��btnFavorite��5        btnFavorite#���  6$   $
��Left=�6L   $��
251,67,0,0q�6g   $	��Top=�6{   $	��131��6�   $��22��6�   6�   �� 5   
   -   5        $��cbEnemy��5   4   $��Right=�6C   $��
0,67,174,0q�6_   $	��Top=�6s   $	��184��6�   �� 5   
   -   5        $��btnEnemy��5        btnEnemy#���  6"   $��Right=�6G   $��	0,67,47,0q�6c   $	��Top=�6v   $	��122��6�   $��22��6�   6�   �� 5   
   -   5        $��cvField��5      $��103,158,105,10q�6    ��5      �� 5       �� ImageSource$ /Fotball_Field.jpg��6   .+�5      � -   5        $��wpDefendersFav��5       � Orientation$ Vertical=�6.   $	��266��6E   $��74��6R   $��Center=�6]   $��Center=�6z    �� Left$ 73��6�   � 5      -   5        $��wpMidfieldersFav��5      $ Vertical=�60   $	��266��6G   $��74��6T   $��Center=�6_   $��Center=�6|   $	 147��6�   � 5      -	   5        $��wpAttackersFav��5      $ Vertical=�6.   $	��266��6E   $��74��6R   $��Center=�6]   $��Center=�6z   $	 221��6�   � 5      -
   5        $��wpDefendersEnemy��5      $ Vertical=�60   $	��266��6G   $��74��6T   $��Center=�6_   $��Center=�6|    �� Right$ 73��6�   � 5      -   5        $��wpMidfieldersEnemy��5      $ Vertical=�62   $	��266��6I   $��74��6V   $��Center=�6a   $��Center=�6~   $	 147��6�   � 5      -   5        $��wpAttackersEnemy��5      $ Vertical=�60   $	��266��6G   $��74��6T   $��Center=�6_   $��Center=�6|   $	 221��6�   �� 5      -   5        $��imgGoalieFav��5      $y�Hidden=�6(   $��38��6<   $ 10��6H   
 �� Top$	 114��6Y   $��38��6j   $��/NoImage.jpg��6u   $
��Left=�6�   $��Center=�6�   �� 5      -   5        $��imgGoalieEnemy��5      $y�Hidden=�6*   $��38��6>   $ 10��6J   $	 114��6\   $��38��6m   $��/NoImage.jpg��6x   $��Right=�6�   $��Center=�6�   5      �� 5   
   -   5          btnSettings#���  5      $
��Left=�69   $��	10,10,0,0q�6T   $	��Top=�6g   
�������6�   �� 5   
   -   5         ��Name$ btnExit��5        btnExit#���  6"   $
��Left=�6F   $��	64,10,0,0q�6a   $	��Top=�6t   
���  ��6�   5       5!      