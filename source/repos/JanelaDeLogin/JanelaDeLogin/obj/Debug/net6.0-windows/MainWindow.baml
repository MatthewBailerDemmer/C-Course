   M S B A M L   `   `   `  ����H  DJanelaDeLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:JanelaDeLoginJanelaDeLogin  5   	       JanelaDeLogin.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:JanelaDeLogin     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��400��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��10 �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       $��10 �6   .+�5"   
   �� $��3��6   $��Login��6    $��1��60   $��4��6=   $	��NaN��6Q   $	��NaN��6]   $��4,4,4,4q�6j   $��36(�6{   $��Center=�6�   $��Center=�6�   $��2��6�   �� 5#   
   $��1��6   $��Usuário��6    $��4,4,4,4q�62   $��4��6C   $��2��6P   $	��NaN��6d   $	��NaN��6p   $��14(�6}   �� 5$   
   $��1��6   $��Senha:��6    $��4,4,4,4q�61   $��6��6B   $��14(�6O   $��2��6]   $	��NaN��6q   $	��NaN��6}   �� 5%   
   -   5         ��Name$ textBoxUsuario��5%      $��1��6*   $��8��6:   $��4,4,4,4q�6N   $��5��6_    �� TextWrapping$
 Wrap=�6l   $	��NaN��6�   $	��NaN��6�   G� 5&   
   -   5         G�Name$ passwordBoxSenha��5&      $��1��60   $��8��6@   $��4,4,4,0q�6T   $��7��6e   $	��NaN��6r   $	��NaN��6~   �� 5'   
   $��Label��6   $
��Left=�6    $��-143,38,0,0q�6;   $��2��6P   $	��Top=�6]   �� 5(   
   -   5        $ textBoxSenha��5(      $��1��6(   $��8��68   $��4,4,4,4q�6L   $��7��6]   $
 Wrap=�6j   $	��NaN��6~   $	��NaN��6�   $y�	Collapsed=�6�   �� 5)   
   -   5         ��Name$ 
botaoLogin��5)      $��1��6%   $��Entrar��65   $��4,4,4,4q�6F   $��8��6W   $��8��6d   $	��NaN��6x   $	��NaN��6�   $��14(�6�   6�   �� 5*   
   -   5        $ botaoMostrar��5*      $��8��6'   $
��Show��67   $��	4,10,4,10q�6F   $��6��6Y   $	��NaN��6f   $	��NaN��6r   6�   5,      5-      