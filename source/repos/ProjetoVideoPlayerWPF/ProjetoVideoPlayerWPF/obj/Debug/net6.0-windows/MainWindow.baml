   M S B A M L   `   `   `  ����P  LProjetoVideoPlayerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProjetoVideoPlayerWPFProjetoVideoPlayerWPF  5   	   &     ProjetoVideoPlayerWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ProjetoVideoPlayerWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��400��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   r� -   5         r�Name$ mediaElementVideo��5      $��5��62   $��4,4,4,4q�6F   $��6��6W   $	��NaN��6h   $	��NaN��6t   �� 5   
   -   5         ��Name$ sliderVolume��5      $��4��6'   $��4,4,4,4q�6;   $��6��6L   $	��NaN��6Y   $	��NaN��6e    � Maximum$	 100Q�6�   �� 5   
   -   5         ��Name$ 	botaoPlay��5      $
��Play��6$   $��4,4,4,4q�63   $��7��6D   $	��NaN��6Q   $	��NaN��6]   6j   �� 5   
   -   5        $ 
botaoPause��5      $��1��6%   $��Pause��65   $��4,4,5,4q�6E   $��7��6V   $	��NaN��6c   $	��NaN��6o   6|   �� 5   
   -   5        $ 	botaoStop��5      $��2��6$   $
��Stop��64   $��4,4,4,4q�6C   $��7��6T   $	��NaN��6a   $	��NaN��6m   6z   �� 5   
   -   5        $ 
botaoAbrir��5      $��3��6%   $��Abrir��65   $��4,4,4,4q�6E   $��7��6V   $	��NaN��6c   $	��NaN��6o   6|   5!      5"      