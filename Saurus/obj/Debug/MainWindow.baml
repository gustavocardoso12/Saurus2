   M S B A M L   `   `   `  ����A  =Saurus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SaurusSaurus  5   	       Saurus.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Saurus     5   	   -   5          � Title$  Tela principal��5   	   $
��1072��6    $
��1701��6.    � Icon$ Imagens/saurus.png��6;    � WindowStartupLocation$ CenterOwner=�6U    � Topmost .  � WindowStyle$
 None=�6�    � 
ResizeMode$ CanResizeWithGrip=�6�    � WindowState$ 	Maximized=�6�    � 	Resources 5	         Saurus.Saurus_BDDataSet   saurus_BDDataSet  clienteViewSource �� Source	 �� Source��%X   &	        &	      7     5   
   6!   �� 5   
    69   �� *	Cliente+8	   5      .��5      � $��Stretch=�6   $��Stretch=�6'   ���	#FF472929
 � DataContext#
 [ 6\   .+�5   
   �� -   5         ��Name$ logo_saurus��5      $y�Visible=�6%   $
��Left=�6:   $	��221��6U   $	��Top=�6b   $	��686��6z   $��Imagens/saurus.png��6�   $��324,283,0,0q�6�    � 5   
   -   5          �Name$ frame��5      $
��Left=�6    $��0,6,0,10q�6;   $��Stretch=�6M     � NavigationUIVisibility$ Hidden=�6i   $�� ��6�   {�. |�.  J� IsHitTestVisible . ��.  6�   o� 5   
   -   5         o�Name$
 menu��5      $��Stretch=�6   ���	#FF32404F$��	0,0,0,682q�6S   .@�5      �� -   5         ��Name$
 Menu��5       ^� 	IsEnabled . ���	#FF32404F$��Inserir��6\   ���	#FFF9F9F9$��SemiBold"�6�   $��33.333(�6�   $��Segoe UI)�6�   $	��223��6�   $��65��6�   ���	#FF32404F6�   �� 5      -   5        ���	#FF32404F���	#FF32404F$��	Atualizar��5   D   ���	#FFF7F7F7$��36(�6p   $��SemiBold"�6~   $	��238��6�   $��65��6�   6�   �� 5      -   5        ���	#FF32404F���	#FF32404F$��Deletar��5   D   ���	#FFF7F7F7$��33.333(�6m   $��SemiBold"�6   $	��212��6�   $��65��6�   6�   �� 5      -   5        $ 	Pesquisar��5      ���	#FF32404F���	#FF32404F$��	Pesquisar��6W   ���	#FFF7F7F7$��33.333(�6�   $��SemiBold"�6�   $	��225��6�   $��75��6�   6�   �� 5      -	   5        $
 sair��5      ���	#FF32404F���	#FF32404F$
��Sair��6R   ���	#FFF7F7F7$��33.333(�6x   $��SemiBold"�6�   $	��267��6�   $��65��6�   6�   5      �� 5   
   -
   5         ��Name$
 nome��5      $	��827��6"   $	��Top=�6.   $��Sistema de cadastro��6F   $
��Wrap=�6a   $��303,504,0,0q�6u   $	��115��6�   $
��Left=�6�   $��80(�6�   
�������6�   5      5      