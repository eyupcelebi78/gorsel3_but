   M S B A M L   `   `   `  ����N  JHalı Saha Yönetim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Halı_Saha_Yönetim.PageScreensHalı_Saha_Yönetim.PageScreens  5      .    (Halı_Saha_Yönetim.PageScreens.Settings   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Halı_Saha_Yönetim.PageScreens     5        N� Title$  Settings��5	       N� 
Background
 �����.��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6-   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgsaha��5      $
��Left=�6!      AutoGenerateColumns .  $	��185��6X   $��	23,35,0,0q�6e   $	��Top=�6x   $	��320��6�   $��Segoe UI Black)�6�   $��14(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ SAHA ID��6<   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *ID+6<     5      $ SAHA ADI��6B   	 6%   �� *
SAHA_ADI+6B     5      $ FİYAT��6?   	 6%   �� *FIYAT+6?     5      $ 	KAPASİTE��6B   	 6%   �� *
KAPASITE+6B   5      �� 5   
   -   5        $��txtad��5      $
��Left=�6   $��23��6:   $��
379,74,0,0q�6F   
 �� TextWrapping$

 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��182��6�   $��Segoe UI Black)�6�   $��14(�6�   �� 5   
   -   5        $��txtfiyat��5      $
��Left=�6"   $��23��6=   $

 Wrap=�6I   $�� ��6]   $	��Top=�6e   $	��182��6}   $��379,127,0,0q�6�   $��Segoe UI Black)�6�   $��14(�6�   �� 5   
   -   5        $��txtkapasite��5      $
��Left=�6%   $��23��6@   $

 Wrap=�6L   $�� ��6`   $	��Top=�6h   $	��182��6�   $��379,178,0,0q�6�   $��Segoe UI Black)�6�   $��14(�6�   �� 5   
   -   5        $��Kaydet��5      $
��Left=�6"   $��378,305,0,0q�6=   $	��Top=�6R   $	��183��6j   $��36��6v   $��Segoe UI Black)�6�   $��14(�6�   �� 5   
   -   5        $	��Sil��5      $
��Left=�6   $��36��6:   $��
28,305,0,0q�6F   $	��Top=�6Z   $	��216��6r   $��Segoe UI Black)�6�   $��14(�6�   �� 5    
   -   5         ��Name$ txtSecim��5       $
��Left=�6$   $��23��6?   $

 Wrap=�6K   $�� ��6_   $	��Top=�6g   $	��216��6   $��
28,277,0,0q�6�   $��Segoe UI Black)�6�   $��14(�6�   �� 5!   
   $��	Saha Adı��6   $
��Left=�6#   $��
379,47,0,0q�6>   $	��Top=�6R   $	��182��6j   $��Segoe UI Black)�6v   $��14(�6�   ���	#FF8078786�   �� 5"   
   $��Fiyat��6   $
��Left=�6    $��379,101,0,0q�6;   $	��Top=�6P   $	��182��6h   $��Segoe UI Black)�6t   $��14(�6�   ���	#FF8078786�   �� 5#   
   $��Kapasite��6   $
��Left=�6#   $��379,152,0,0q�6>   $	��Top=�6S   $	��182��6k   $��Segoe UI Black)�6w   $��14(�6�   ���	#FF8078786�   �� 5$   
   $��Silinecek Sahanın İD si��6   $
��Left=�62   $��
28,248,0,0q�6M   $	��Top=�6a   $	��213��6y    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Segoe UI Black)�6�   $��14(�6�   z�5%      V� 5&      .~�5'      �� �� 5(       �� AngleX$
 0.26Q�6$   �� 5)       �� Angle$ -0.199Q�6&   T� 5*      5+      5-      5/      50      