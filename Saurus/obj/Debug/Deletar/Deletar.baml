   M S B A M L   `   `   `  ����A  =Saurus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Saurus.DeletarSaurus.Deletar  5      clr-namespace:SaurusSaurus  5          Saurus.Deletar.Deletar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Saurus.Deletar     5      'Saurusclr-namespace:Saurus     5        N� Title$  Deletar��5	      $	��828��6   $
��1344��6$    � 	Resources 5
         Saurus.Saurus_BDDataSet   saurus_BDDataSet  clienteViewSource �� Source �� Source��%X   &	        &	      7     5   
   6"   �� 5   
    69   �� *	Cliente+8   5      .��5      � ���	#FF472929.+�5   
   �� -   5         ��Name$ 	CPF_Label��5      $	��168��6#   $	��Top=�6/   $��
13,304,0,0q�6G   $��61��6[   $
��Left=�6g   $��32(�6�   $
��Bold"�6�   
�������$	��CPF��6�   �� 5   
   -   5        $ 
Nome_label��5      $	��463��6$   $	��Top=�60   $��
10,429,0,0q�6H   $��60��6\   $
��Left=�6h   $��32(�6�   $
��Bold"�6�   
�������$��Nome completo��6�   �� 5   
   -   5        $ data_nasc_label��5      $	��521��6)   $	��Top=�65   $��
10,547,0,0q�6M   $��60��6a   $
��Left=�6m   $��32(�6�   $
��Bold"�6�   
�������$��Data de Nascimento��6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $	��557��6'   $	��Top=�63   $��Deletar dados��6K   $
��Wrap=�6`   $��438,106,0,0q�6t   $	��115��6�   $
��Left=�6�   $��80(�6�   $
��Bold"�6�   
�������6�   �� 5   
   -   5         ��Name$ 
Deletarbtn��5      $	��402��6%   $	��Top=�61   $��501,660,0,0q�6I   $��66��6^   $
��Left=�6j   $��40(�6�   $
��Bold"�6�   
�������$��Deletar��6�   ���	#FF2A3C91���	#FF4729296�   �� 5   
   -   5        $ Proximo��5      $	����6"   $
��Left=�65   $��133,220,0,0q�6P   $	��Top=�6e   $	��130��6}   $��40(�6�   ���	#FF2A3C91
�������$
��Bold"�6�   ���	#FF472929$��66��6�   $��Segoe MDL2 Assets)�6�   6  �� 5   
   -   5        $ anterior��5      $	����6#   $
��Left=�66   $��
-1,220,0,0q�6Q   $	��Top=�6e   $	��137��6}   $��40(�6�   ���	#FF2A3C91
�������$
��Bold"�6�   ���	#FF472929$��66��6�   $��Segoe MDL2 Assets)�6�   6  � 5   
   -   5         �Name$ grid2��5      $
��Left=�6   $��710,274,0,0q�69   $	��Top=�6N    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   	 � RowDefinitions	 5      �� 5       $
��Auto �6    5"      � 5#   
   -	   5        $ grid4��5#      $
��Left=�6   $��774,386,0,0q�69   $	��Top=�6N    5$      �� 5%      $
��Auto �6#   �� 5&      $
��Auto �6#   	 5(      �� 5)      $
��Auto �6    5+      � 5,   
   -
   5        $ grid6��5,      $
��Left=�6   $��762,522,0,0q�69   $	��Top=�6N    5-      �� 5.      $
��Auto �6#   �� 5/      $
��Auto �6#   	 51      �� 52      $
��Auto �6    54      � 55   
   -   5        $ grid1��55      $
��Left=�6   $��504,305,0,0q�69   $	��Top=�6N    56      �� 57      $
��Auto �6#   �� 58      $
��Auto �6#   	 5:      �� 5;      $
��Auto �6    5=      � 5>   
   -   5        $ grid3��5>      
 � DataContext#
 [ 6   $
��Left=�6O   $��496,413,0,0q�6j   $	��Top=�6    5?      �� 5@      $
��Auto �6#   �� 5A      $
��Auto �6#   	 5C      �� 5D      $
��Auto �6    5F      � 5G   
   -   5        $ grid5��5G      $
��Left=�6   $��504,525,0,0q�6:   $	��Top=�6O    5H      �� 5I      $
��Auto �6#   �� 5J      $
��Auto �6#   	 5L      �� 5M      $
��Auto �6    5O      � 5P   
   -   5        $ grid7��5P      $
��Left=�6   $��	0,180,0,0q�69   $	��Top=�6L   $y�Hidden=�6d    5Q      �� 5R      $
��Auto �6#   �� 5S      $
��Auto �6#   	 5U      �� 5V      $
��Auto �6    .+�5X      �� $��Numero interno:��6   $��0��6.   $
��Left=�6>   $��3q�6Y   $��0��6d   $��Center=�6q   �� 5Y      -   5         ��Name$ numero_internoTextBox��5Y      $��1��65   $
��Left=�6E   $��23��6`   $��3q�6l   $��0��6w   $��Center=�6�   $	��120��6�   ��6�   �� *Numero_interno+ �� Mode$ OneWay=�6�   5Z      � 5[   
   -   5        $ grid8��5[      #
 [ 6   $
��Left=�6O   $��545,330,0,0q�6j   $	��Top=�6    5\      �� 5]      $
��Auto �6#   �� 5^      $
��Auto �6#   	 5`      �� 5a      $
��Auto �6    5c      � 5d   
   -   5        $ grid9��5d      #
 [ 6   $
��Left=�6O   $��599,471,0,0q�6j   $	��Top=�6    5e      �� 5f      $
��Auto �6#   �� 5g      $
��Auto �6#   	 5i      �� 5j      $
��Auto �6    5l      � 5m   
   -   5        $ grid11��5m      #
 [ 6   $
��Left=�6P   $��536,404,0,0q�6k   $	��Top=�6�    5n      �� 5o      $
��Auto �6#   �� 5p      $
��Auto �6#   	 5r      �� 5s      $
��Auto �6    5u      � 5v   
   -   5        $ grid12��5v      #
 [ 6   $
��Left=�6P   $��576,544,0,0q�6k   $	��Top=�6�    5w      �� 5x      $
��Auto �6#   �� 5y      $
��Auto �6#   	 5{      �� 5|      $
��Auto �6    5~      � 5   
   -   5        $ grid10��5      #
 [ 6   $
��Left=�6P   $��496,332,0,0q�6k   $	��Top=�6�    5�      �� 5�      $
��Auto �6#   �� 5�      $
��Auto �6#   	 5�      �� 5�      $
��Auto �6    .+�5�      �� -   5        $ 
cPFTextBox��5�      $��1��6*   $
��Left=�6:   $��39��6U   $��4,0,-172,-10q�6a   $��0��6w   $��Center=�6�   $	��294��6�   $��32(�6  ��6�   �� *CPF+$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6  5�      � 5�   
   -   5        $ grid13��5�      #
 [ 6   $
��Left=�6P   $��536,428,0,0q�6k   $	��Top=�6�    5�      �� 5�      $
��Auto �6#   �� 5�      $
��Auto �6#   	 5�      �� 5�      $
��Auto �6    .+�5�      �� -   5        $ nomeTextBox��5�      $��1��6+   $
��Left=�6;   $��46��6V   $��-39,0,-181,-17q�6b   $��0��6z   $��Center=�6�   $	��346��6�   $��32(�6  ��6�   �� *Nome+$ TwoWay=� .  . 6  5�      � 5�   
   -   5        $ grid14��5�      #
 [ 6   $
��Left=�6P   $��572,540,0,0q�6k   $	��Top=�6�    5�      �� 5�      $
��Auto �6#   �� 5�      $
��Auto �6#   	 5�      �� 5�      $
��Auto �6    .+�5�      (  "System.Windows.Controls.DatePicker  -   5          Name$ data_NascimentoDatePicker��5�      $��1��6<   $
��Left=�6L   $��-75,13,-163,-32q�6g   $��0��6�   $��Center=�6�   $��49��6  $	��271��6$  $��32(�60     SelectedDate 6�   �� *Data_Nascimento+$ TwoWay=� .  . 60  5�      5�      5�      