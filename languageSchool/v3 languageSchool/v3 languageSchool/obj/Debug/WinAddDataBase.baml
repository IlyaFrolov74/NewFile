   M S B A M L   `   `   `  ����L  Hv3 languageSchool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:v3_languageSchoolv3_languageSchool  5   	   &     v3_languageSchool.WinAddDataBase   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:v3_languageSchool     5   	     � Title$  languageSchool��5   	   $	��450��6    $	��800��6-    � Icon$ Resources/school_logo.png��5	   
   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      .+�5'   
   (  "System.Windows.Controls.DatePicker  -   5        $��DateAdd��5)      $��12(�5*      $��Comic Sans MS)�5+         Text$# Введите возраст��5,      
�������$��Center=�5.      $��5��5/      $��4��50      $��3��51      $	��150��52      $
��Left=�53      55      �� 58   
   -   5        $��Center=�59      $��Center=�5:      $��8��5;      $��2��5<      $��0��5=      ���#04a0ff.��5A      �� $ ��главное меню >>��6   5C      5D      �� 5G   
   $��0��6   $��0��6    $��2��6-   $��2��6>   $��Resources/school_logo.png��6R   6x   �� 5K   
   -   5         ��Name$ 
SecondName��5M      $	��150��6!   $��2��5N      $��15(�5O      $��Comic Sans MS)�5P      $��0��5Q      $��4��5R      $#��введите фамилию��5S      $
��Left=�5T      $��Center=�5U      .��6(   5W      �� 5Z   
   -   5        $ NameAdd��5\      $	��150��6   $��2��5]      $��15(�5^      $��Comic Sans MS)�5_      $��1��5`      $��4��5a      $��введите имя��5b      $
��Left=�5c      $��Center=�5d      .��6(   5f      �� 5i   
   -   5        $ MiddleNameAdd��5k      $	��150��5l      $��2��5m      $��15(�5n      $��Comic Sans MS)�5o      $��2��5p      $��4��5q      $%��введите отчество��5r      $
��Left=�5s      $��Center=�5t      .��6(   5u      �� 5y   
   -   5        $ 	GenderAdd��5{      $	��150��5|      $��2��5}      $��15(�5~      $��Comic Sans MS)�5      $��3��5�      $��4��5�      $��укажите пол��5�      $
��Left=�5�      $��Center=�5�      .��6(   5�      �� 5�   
   -   5        $ PhoneAdd��5�      $	��150��5�      $��2��5�      $��15(�5�      $��Comic Sans MS)�5�      $��4��5�      $��4��5�      $"�� номер телефона��6   $
��Left=�5�      $��Center=�5�      6*   �� 5�   
   -   5        $ EmailAdd��5�      $	��150��5�      $��3��5�      $��15(�5�      $��Comic Sans MS)�5�      $��6��5�      $��4��5�      $��введите Email��5�      $
��Left=�5�      $��Center=�5�      5�      �� 5�   
   -	   5        $ IDClientNew��5�      $��1��5�      $��1��5�      6   �� 5�   
   -
   5        $��Comic Sans MS)�5�      ���#04a0ff$��7��5�      $��4��5�      $��3��5�      $
��Left=�5�      $��Center=�5�      .��5�      �� $5��/Добавить данные о клинете��6   6;   5�      5�      5�      