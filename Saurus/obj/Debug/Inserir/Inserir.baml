   M S B A M L   `   `   `  ����A  =Saurus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Saurus.InserirSaurus.Inserir  5      clr-namespace:SaurusSaurus  5          Saurus.Inserir.Inserir   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Saurus.Inserir     5      'Saurusclr-namespace:Saurus     5      -   5          N�Name$  Inserir1��5   +    N� Title$ Inserir��5	      $	��666��6   $
��1083��6$    N� ShowsNavigationUI .  � 	Resources 5         Saurus.Saurus_BDDataSet   saurus_BDDataSet  clienteViewSource �� Source �� Source��%X   &	        &	      7     5   
   6"   �� 5   
    69   �� *	Cliente+8   5      .��5      � ���	#FF472929$��10,0,-614,-122q�6"   .+�5   
   �� -   5         ��Name$ 	CPF_Label��5      $	��CPF��6#   $
��Left=�61   $��
41,259,0,0q�6L   $	��Top=�6`   $��61��6x   $	��168��6�   $��32(�6�   $
��Bold"�6�   
�������6�   �� 5   
   -   5        $ 
Nome_label��5      $��Nome completo��6$   $
��Left=�6<   $��
30,384,0,0q�6W   $	��Top=�6k   $��60��6�   $	��463��6�   $��32(�6�   $
��Bold"�6�   
�������6�   �� 5   
   -   5        $ data_nasc_label��5      $��Data de Nascimento��6)   $
��Left=�6F   $��
34,502,0,0q�6a   $	��Top=�6u   $��60��6�   $	��521��6�   $��32(�6�   $
��Bold"�6�   
�������6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��
346,81,0,0q�6B   $
��Wrap=�6V   $��Inserção de dados��6j   $	��Top=�6�   
�������$��80(�6�   $
��Bold"�6�   $	��115��6�   $	��708��6�   �� 5   
   -   5         ��Name$ 
Inserirbtn��5      $��Inserir��6%   $
��Left=�67   $��493,621,0,0q�6R   $	��Top=�6g   $	��402��6   $��40(�6�   ���	#FF2A3C91
�������$
��Bold"�6�   ���	#FF472929$��66��6�   6�   � 5   
   -   5        	 �Name$	 grid2��5      
 � DataContext#
 [ 6   $
��Left=�6O   $��620,276,0,0q�6j   $	��Top=�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    .+�5       �� -   5         ��Name$ 
cPFTextBox��5       $��1��6*   $
��Left=�6:   $��46��6U   $��6,0,-197,-17q�6a   $��0��6w   $��Center=�6�   $	��317��6�   $��32(�6  ��6�   �� *CPF+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6  5!      � 5"   
   -	   5        $	 grid3��5"      #
 [ 6   $
��Left=�6O   $��626,418,0,0q�6j   $	��Top=�6    5#      �� 5$      $
��Auto �6#   �� 5%      $
��Auto �6#    5'      �� 5(      $
��Auto �6    .+�5*      �� -
   5        $ NomeTextBox��5*      $��1��6+   $��Right=�6;   $��59��6W   $��0,-33,-384,3q�6c   $��0��6y   $��Center=�6�   $	��507��6�   $��32(�6
  ��6�   �� *Nome+$ TwoWay=� .  . 6
  5+      � 5,   
   -   5        $	 grid4��5,      #
 [ 6   $
��Left=�6O   $��636,522,0,0q�6j   $	��Top=�6    5-      �� 5.      $
��Auto �6#   �� 5/      $
��Auto �6#    51      �� 52      $
��Auto �6    .+�54      (  "System.Windows.Controls.DatePicker  -   5          Name$
 data��54      $
��Left=�6'   $��0,-7,-277,-20q�6B   $��0��6Y   $��Center=�6�   $��59��6�   $	��401��6�   $��32(�6	  $��2��6     SelectedDate 6f   �� *Data_Nascimento+$ TwoWay=� .  . 6  55      57      58      