   M S B A M L   `   `   `  ����G  CEnglishTests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EnglishTestsEnglishTests  5   	       EnglishTests.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:EnglishTests     5   	     � Title$  
MainWindow��5   	   $	��530��6   $	��450��6)   $	��450��65   $	��530��6D    � WindowStartupLocation$ CenterScreen=�6T   .��5	      � ���	#FFFAE3CD � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      $
��105* �6   �� 5      $	��98* �6   �� 5      $	��98* �6   �� 5      $	��68* �6   �� 5      $
��123* �6   .+�5   
   �� $��English Test��6   $��72(�6'   $��Center=�65   $��Center=�6W   $��Harlow Solid Italic)�6{   ���	#FFAC53536�   � 5   
   -   5         �Name$ Login_input��5      $��1��6$   .+�5      �� ���	#FFAC5353$��56��6)   $	��354��65    �� RadiusY$ 30.223��6A    �� RadiusX$ 30.223��6R   �� 5      -   5         ��Name$ LoginT��5      $��56��6&    �� TextWrapping$
 Wrap=�62   $��Login��6F   $	��354��6S   	 �� SelectionBrush	 �	#FF595959$��Center=�6�   $��17,0,0,0q�6�   $��22(�6�   ��6_   Z� ��6u   Z� 6  5      � 5   
   -   5        $ Password_input��5      $��2��6'   .+�5      �� ���	#FFAC5353$��56��6)   $	��354��65   $ 30.223��6A   $ 30.223��6R   �� 5      -   5        $ PassT��5      $��56��6%   $
 Wrap=�61   $��Password��6E   $	��354��6U   	 �	#FF595959$��Center=�6�   $��17,0,0,0q�6�   $��22(�6�   ��6a   Z� ��6w   Z� 6  5      � 5   
   -   5        $ LogIn_button��5      $��3��6%   
 � Cursor$

 Hand��62   .+�5      �� -   5        $��LogIn��5      $��56��6$   $	��176��60   $��Center=�6<   $��Center=�6`   $��22(�6�    K� ZIndex$ 1��6�   6�   �� 5      ���	#FFAC5353$��56��6)   $	��176��65   $ 30.223��6A   $ 30.223��6R   5       � 5!   
   -   5        $ Register_button��5!      $��69��6(   $��4��64   $	��213��6A   $��Bottom=�6M   $��Right=�6h   $��	0,0,28,10q�6�   $

 Hand��6�   .+�5"      �� $��Register��6   $��36(�6'   $��Center=�65   $��Center=�6Y   $��Harlow Solid Italic)�6{   ���	#FFAC53536�   5#      5%      5&      