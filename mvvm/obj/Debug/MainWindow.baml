   M S B A M L   `   `   `  ����?  ;mvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:mvvmmvvm  5   	       mvvm.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:mvvm     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   �� name6   �� 5   
   6   �� 5   
   payment kind6"   �� 5   
   ��5      �� 5      .R�5      �� .+�5      �� ��6$   �� *Employee.Charge+ �� Mode$ TwoWay=�6T   5      5      .@�5      �� .��6   salary6#   �� 5      .��6   hourly wage6(   �� 5      .��6   fee6    5      �� 5   
   salary or bet6#   �� 5   
   ��5      �� 5      .R�5      �� .+�5      �� ��6$   �� *Employee.Selection+$ TwoWay=�6W   5      5       .@�5"      �� .��6   salary6#   �� 5#      -   5        $	��bet��5#      .��6&   bet6+   5$      �� 5%   
   -   5        $��hour_amount��5%      y�6'   �� *ViewModel.Is_shown+hour amount6^   �� 5&   
   -   5        $��amount��5&      y�6    �� *ViewModel.Is_shown+6L   5'      5(      