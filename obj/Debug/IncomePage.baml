   M S B A M L   `   `   `  ����M  IMoneyManagerRodina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MoneyManagerRodinaMoneyManagerRodina  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      #    MoneyManagerRodina.IncomePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:MoneyManagerRodina     5      Dvlc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        N� Title$  
IncomePage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Доходы:��6   $
��36px(�5      $��Center=�5         	TextColor#��[  5      $��Center=�5      �� 5   
   $��1��6   .+�5      �� $��Доходы��6   $
��36px(�5       $��Center=�5!      #��[  5"        LiveCharts.Wpf.PieChart  5#      -   5        $��pieChart��5#      $��500px��5$      $��0 100px 0 0q�5%      5&      �� 5(   
   $��0.0 рублей��6   $
��36px(�5)      $��Center=�5*        SecondaryColor#��[ 5+      $��1��5,      $��Center=�5-      �� 5/   
   $��1��6   $��1��50      $��Center=�51      .+�53      �� $!��Выбрать период��6   $��300px��54      $
��60px��55      #��[ 56        PrimaryColor#��[ 57      $
��24px(�58      $
��Bold"�59       � Cursor$
 Hand��5:      $��
0 30px 0 0q�5;      �� 5=      $!��Добавить доход��6   $��300px��5>      $
��60px��5?      #��[ 5@      #��[ 5A      $
��24px(�5B      $
��Bold"�5C      $��
0 30px 0 0q�5D      $
 Hand��5E      �� 5G      $#��Новая категория��6   $��300px��5H      $
��60px��5I      #��[ 5J      #��[ 5K      $
��24px(�5L      $
��Bold"�5M      $��
0 30px 0 0q�5N      $
 Hand��5O      5Q      5R      5S      