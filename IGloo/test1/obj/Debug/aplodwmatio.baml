   M S B A M L   `   `   `  ����	  test1    test1.aplodwmatio   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6?   -   5          �Name$  Window��5       � Title$ aplodwmatio��5      $
��1024��5	      $	��768��6    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�62    � 	Resources 5
         Storyboard1  lighton �� TargetProperty �� 
TargetName R� KeyTime R� Value  System.Windows.Visibility  lighton_rev	   Visible
   Hidden 
 light2  light_Copy1��%  &	        &	      &	 �     &	 �    &	 ;    �� 5      6   �� 5      .��5      T� $ (UIElement.Visibility)�6#   $ ___Image___light1_1��6V   ..�5      i� $ 0:0:0.1��6    5       5      Visible=�6   5      5      5      �� 5      .��5      T� $ (UIElement.Visibility)�6#   $ ___Image___light1_1��6V   ..�5      i� $ 0��6   # Z	 6)   i� 5      $ 0:0:0.1��6   # Z
 6/   5      5      �� 5      .��5      T� $ (UIElement.Visibility)�6#   $ image��6V   ..�5      i� $ 0:0:0.1��6   # Z	 6/   5      5      �� 5       .��5!      T� $ (UIElement.Visibility)�6#   $ image��6V   ..�5"      i� $ 0:0:0.1��6   # Z
 6/   5#      5$      5%       � Triggers 5&      :� 5'       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5(      �� #��[  6   5)      :� 5*      $# UIElement.MouseLeftButtonDown��6    :� 
SourceName$ ___Image___light1_��6=   .[�5+      �� -   5         ��Name$ lighton_BeginStoryboard��5+      #��[ 66   5,      :� 5-      $# UIElement.MouseLeftButtonDown��6   $ ___Image___light1_1��6=   .[�5.      �� -   5        $! lighton_rev_BeginStoryboard��5.      #��[ 6:   5/      :� 50      $# UIElement.MouseLeftButtonDown��6   $ ___Image___light2_��6=   .[�51      �� -   5        $ light2_BeginStoryboard��51      #��[ 65   52      :� 53      $# UIElement.MouseLeftButtonDown��6   $ image��6=   .[�54      �� -   5        $! light_Copy1_BeginStoryboard��54      #��[ 6:   55      .��58      � -   5         �Name$ 
LayoutRoot��58       � ColumnDefinitions 59      �� 5:      $
��248* �6   �� 5;      $
��169* �6   �� 5<      $	��91* �6   .+�5>      �� $��3��6
   $!��PH_121222_2700-1140x760.jpg��6   $
��Fill=�6C   �� 5?      -   5        $
��Back��5?      $
��Left=�6   $��
92,660,0,0q�65   $	��Top=�6I   $��75��6a   6l   �� 5@      -   5         ��Name$ image��5@   
   $��216,218.266,58,305.662q�6   $��	light.png��69   $
��Fill=�6L    J� Opacity$
 0.37Q�6[   $y�Hidden=�6j   �� 5A      -	   5        $ ___Image___light1_1��5A   
   $��1��6'   $��106,218.266,10,305.662q�67   $��	light.png��6W   $
��Fill=�6j   $
 0.37Q�6y   $y�Hidden=�6�   �� 5B      -
   5        $ ___Image___light1_��5B   
   $��195.348,301,104,377.734q�6&   $��Untitled-1.png��6G   $
��Fill=�6_   $��1��6n    J� RenderTransformOrigin$ 0.5,0.5&�6~   z�5C      V� 5D      .~�5E      ��  �� ScaleY$ 1Q�6    �� ScaleX$ 1Q�6!   �� 5F       �� AngleY$ 0Q�6    �� AngleX$ 0Q�6    �� 5G       �� Angle$ 0Q�6   T� 5H      5I      5K      �� 5L      -   5        $ ___Image___light2_��5L   
   $��303,301,155,378.734q�6&   $��Untitled-1.png��6C   $
��Fill=�6[   $ 0.5,0.5&�6j   z�5M      V� 5N      .~�5O      �� $ 1Q�6   $ -1Q�6!   �� 5P      $ 0Q�6   $ 0Q�6    �� 5Q      $ 0Q�6   T� 5R      5S      5U      �� 5V      -   5         ��Name$ _switch��5V      }�. $
��Left=�60   $	��768��6K    � UseLayoutRounding .  $	��Top=�6r   $
��1024��6�   $��3��6�   $��
-8,-30,0,0q�6�   5W      5X      