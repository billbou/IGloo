   M S B A M L   `   `   `  ����	  test1    test1.aplodwmatio   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6?   -   5          �Name$  Window��5       � Title$ 	Ice Hotel��5      $
��1024��5	      $	��768��6    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�62    � Icon$ 	igloo.png��6W    � 	Resources 5
         Storyboard1  lighton �� TargetProperty �� 
TargetName R� KeyTime	 R� Value  System.Windows.Visibility  lighton_rev
   Visible   Hidden 
 light2  light_Copy1  OnMouseLeftButtonDown1  OnMouseLeftButtonDown_Copy1��%  &	        &	      &	 �     &	 �    &	 ;    &	 �    &	 d    �� 5      6   �� 5      .��5      T� $ (UIElement.Visibility)�6#   $ ___Image___light1_1��6V   ..�5      i� $ 0:0:0.1��6   	 5       5      Visible=�6   5      5      5      �� 5      .��5      T� $ (UIElement.Visibility)�6#   $ ___Image___light1_1��6V   ..�5      i� $ 0��6   #	 Z
 6)   i� 5      $ 0:0:0.1��6   #	 Z 6/   5      5      �� 5      .��5      T� $ (UIElement.Visibility)�6#   $ image��6V   ..�5      i� $ 0:0:0.1��6   #	 Z
 6/   5      5      �� 5       .��5!      T� $ (UIElement.Visibility)�6#   $ image��6V   ..�5"      i� $ 0:0:0.1��6   #	 Z 6/   5#      5$      �� 5%      .��5&      T� $ (UIElement.Visibility)�6#   $ image2��6V   ..�5'      i� $ 0:0:0.1��6   #	 Z
 6/   5(      5)      �� 5*      .��5+      T� $ (UIElement.Visibility)�6#   $ image2��6V   ..�5,      i� $ 0:0:0.1��6   #	 Z 6/   5-      T� 5.      $ (FrameworkElement.Cursor)�6#   $ image2��6Y   ..�5/      i� $ 0��6   	 50      ��51      Hand��6   53      i� 54      $ 0:0:0.1��6   	 6/   Z� 55      56      57       � Triggers 58      :� 59       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5:      �� #��[  6   5;      :� 5<      $# UIElement.MouseLeftButtonDown��6    :� 
SourceName$ ___Image___light1_��6=   .[�5=      �� -   5         ��Name$ lighton_BeginStoryboard��5=      #��[ 66   5>      :� 5?      $# UIElement.MouseLeftButtonDown��6   $ ___Image___light1_1��6=   .[�5@      �� -   5        $! lighton_rev_BeginStoryboard��5@      #��[ 6:   5A      :� 5B      $# UIElement.MouseLeftButtonDown��6   $ ___Image___light2_��6=   .[�5C      �� -   5        $ light2_BeginStoryboard��5C      #��[ 65   5D      :� 5E      $# UIElement.MouseLeftButtonDown��6   $ image��6=   .[�5F      �� -   5        $! light_Copy1_BeginStoryboard��5F      #��[ 6:   5G      :� 5H      $# UIElement.MouseLeftButtonDown��6   $ image1��6=   .[�5I      �� -   5        $, &OnMouseLeftButtonDown1_BeginStoryboard��5I      #��[ 6E   5J      :� 5K      $# UIElement.MouseLeftButtonDown��6   $ image2��6=   .[�5L      �� -   5        $1 +OnMouseLeftButtonDown_Copy1_BeginStoryboard��5L      #��[ 6J   5M      .��5P      � -   5         �Name$ 
LayoutRoot��5P       � ColumnDefinitions 5Q      �� 5R      $
��248* �6   �� 5S      $
��169* �6   �� 5T      $	��91* �6   .+�5V      �� $��3��6
   $!��PH_121222_2700-1140x760.jpg��6   $
��Fill=�6C    � Cursor$ Arrow��6R   �� 5W      -	   5         ��Name$ image��5W   
   $��216,218.266,58,305.662q�6   $��	light.png��69   $
��Fill=�6L    J� Opacity$
 0.37Q�6[   $y�Hidden=�6j   $
 Hand��6~   �� 5X      -
   5        $ ___Image___light1_1��5X   
   $��1��6'   $��106,218.266,10,305.662q�67   $��	light.png��6W   $
��Fill=�6j   $
 0.37Q�6y   $y�Hidden=�6�   $
 Hand��6�   �� 5Y      -   5        $ ___Image___light1_��5Y   
   $��195.348,301,104,377.734q�6&   $��Untitled-1.png��6G   $
��Fill=�6_   $��1��6n    J� RenderTransformOrigin$ 0.5,0.5&�6~   $
 Hand��6�   z�5Z      V� 5[      .~�5\      ��  �� ScaleY$ 1Q�6    �� ScaleX$ 1Q�6!   �� 5]       �� AngleY$ 0Q�6    �� AngleX$ 0Q�6    �� 5^       �� Angle$ 0Q�6   T� 5_      5`      5b      �� 5c      -   5        $ ___Image___light2_��5c   
   $��303,301,155,378.734q�6&   $��Untitled-1.png��6C   $
��Fill=�6[   $ 0.5,0.5&�6j   $
 Hand��6�   z�5d      V� 5e      .~�5f      �� $ 1Q�6   $ -1Q�6!   �� 5g      $ 0Q�6   $ 0Q�6    �� 5h      $ 0Q�6   T� 5i      5j      5l      �� 5m      -   5        $��102,592,281.564,61.845q�5m   
   $��arrowback.png��6*   $
��Fill=�6A   $
 Hand��6l   �� 5n      -   5        $ image1��5n   
   $��2��6   $!��26.334,682.22,67.515,15.734q�6*   $��
router.png��6O   $
��Fill=�6c   $
 Hand��6r   �� 5o      -   5        $ image2��5o   
   $��2��6   $��27.347,592,67.515,70.933q�6*   $��
signal.png��6L   $
��Fill=�6`   $y�Hidden=�6o   $
 Hand��6�   5p      5q      