   M S B A M L   `   `   `  ����M  IMoneyManagerRodina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MoneyManagerRodinaMoneyManagerRodina  5      !    MoneyManagerRodina.HomePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:MoneyManagerRodina     5        N� Title$  HomePage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Основной счёт��6   $
��36px(�5      $��Center=�5         	TextColor#��[  5      $��Center=�5      �� 5   
   $��0.0 рублей��6   $
��40px(�5      $��Center=�5        SecondaryColor#��[ 5      $��1��5      $
��Bold"�5      $��Center=�5       �� 5!   
   $��Доходы��6   $��1��5"      #��[  5#      $��Center=�5$      $
��24px(�5%      �� 5&   
   $��Расходы��6   $��1��5'      $��1��5(      #��[  5)      $��Center=�5*      $
��24px(�5+      �� 5,   
   $��2��6   $��2��5-      $��Center=�5.      $��Center=�5/       �� Orientation$ 
Horizontal=�50      .+�51      �� $��Создать счёт��6   $��300px��52      $
��60px��53        ElementsColor#��[ 54      #��[  55      $
��24px(�56      $
��Bold"�57       � Cursor$
 Hand��58      �� 59      $!��Добавить доход��6   $��300px��5:      $
��60px��5;      #��[ 5<        PrimaryColor#��[ 5=      $
��24px(�5>      $
��Bold"�5?      $��
30px 0 0 0q�5@      $
 Hand��5A      �� 5B      $#��Добавить расход��6   $��300px��5C      $
��60px��5D      #��[  5E      #��[ 5F      $
��24px(�5G      $
��Bold"�5H      $��
30px 0 0 0q�5I      $
 Hand��5J      5K      5L      5M      