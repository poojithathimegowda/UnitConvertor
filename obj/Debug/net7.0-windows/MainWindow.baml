   M S B A M L   `   `   `  ����H  DUnitConvertor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:UnitConvertorUnitConvertor  5   	       UnitConvertor.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:UnitConvertor     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Enter Value:��6   $��0��6'   $��0��64   $��Center=�6D   $��5q�6_   �� 5   
   -   5        $��
InputValue��5      $��0��6$   $��1��61   $	��200��6A   $��5q�6M   �� 5   
   $��Convert From:��6   $��1��6(   $��0��65   $��Center=�6E   $��5q�6`   �� 5   
   -   5        $��FromUnit��5      $��1��6#   $��1��60   $	��200��6@   $��5q�6L   .@�5      �� .��6   Meters6#   �� 5      .��6   
Kilometers6'   �� 5      .��6   Feet6!   �� 5      .��6   Miles6"   5       �� 5"   
   $��Convert To:��6   $��2��6&   $��0��63   $��Center=�6C   $��5q�6^   �� 5#   
   -   5        $��ToUnit��5#      $��2��6!   $��1��6.   $	��200��6>   $��5q�6J   .@�5$      �� .��6   Meters6#   �� 5%      .��6   
Kilometers6'   �� 5&      .��6   Feet6!   �� 5'      .��6   Miles6"   5(      �� 5*   
   $��3��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $
��Left=�6K   $��5q�6f   .+�5+      �� -   5        $��Convert��5+      $	��100��6'   $��5q�63   6>   �� 5,      -   5        $��Reset��5,      $	��100��6%   $��5q�61   6<   5-      �� 5/   
   -   5        $��Result��5/      $��4��6"   $��1��6/   $��Center=�6?   $��5q�6Z   $��16(�6e   $
��Bold"�6s   50      51      