   M S B A M L   `   `   `  ����	  test1    test1.dwmatioslux   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6?   -   5          �Name$  Window��5       � Title$ dwmatioslux��5      $
��1024��5      $	��768��6    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�62    � 	Resources 5	         OnMouseLeftButtonDown1 �� TargetProperty �� 
TargetName R� KeyTime  System.Windows.Visibility   Visible	 R� Value  OnMouseLeftButtonDown_Copy1
   Hidden & "Pingu__Igloo_Adventures___Clip_mp4 p� Source  tvstart �� KeyTime �� Value��%  &	        &	 �     &	 *    &	 �    �� 5
      .��5      T� $ (UIElement.Visibility)�6#   $ image1��6V   ..�5      i� $ 0:0:0.1��6   #	 Z 6/   5      5      �� 5      .��5      T� $ (UIElement.Visibility)�6#   $ image1��6V   ..�5      i� $ 0:0:0.1��6   #	 Z
 6/   5      5      �� 5      .��5      p� $( "Pingu- Igloo Adventures - Clip.mp4?�6   $( "Pingu__Igloo_Adventures___Clip_mp4��6?   5      �� 5      .��5      T� $ (UIElement.Visibility)�6#   $( "Pingu__Igloo_Adventures___Clip_mp4��6V   ..�5      i� $ 0��6   #	 Z 6)   5      �� 5      $ (MediaElement.IsMuted)�6$   $( "Pingu__Igloo_Adventures___Clip_mp4��6W   .p�5      s� $ 0��6    .  6*   5      5      5       � Triggers 5       :� 5!       :� RoutedEvent$# UIElement.MouseLeftButtonDown��6    :� 
SourceName$ image��6=   .[�5"      �� #��[  6   5#      :� 5$      $# UIElement.MouseLeftButtonDown��6   $ image1��6=   .[�5%      �� -   5         ��Name$1 +OnMouseLeftButtonDown_Copy1_BeginStoryboard��5%      #��[ 6J   5&      :� 5'      $ FrameworkElement.Loaded��6   .[�5(      �� -   5        $8 2Pingu__Igloo_Adventures___Clip_mp4_BeginStoryboard��5(      #��[ 6Q   ?� 5)       �� BeginStoryboardName$8 2Pingu__Igloo_Adventures___Clip_mp4_BeginStoryboard��6   5*      :� 5+      $# UIElement.MouseLeftButtonDown��6   $ image2��6=   .[�5,      �� -   5        $ tvstart_BeginStoryboard��5,      #��[ 66   5-      :� 5.      $# UIElement.MouseLeftButtonDown��6   $ label��6=   .[�5/      ?� $8 2Pingu__Igloo_Adventures___Clip_mp4_BeginStoryboard��6   50      .��53      � -   5         �Name$ 
LayoutRoot��53      .+�54      �� $%��futureancestors_11-1140x760.jpg��6
   $
��Fill=�63   $��-1.333,-0.5,1.333,0.5q�6B   �� 55      -   5         ��Name$
 pisw��55      $
��Back��6   $
��Left=�6(   $��114,647,0,0q�6C   $	��Top=�6X   $��75��6p   6{   �� 56      -   5         ��Name$ image��56   
   $ ��454.5,39.167,457.5,497.833q�6   $��lightlux.png��6=   $
��Fill=�6S   �� 57      -   5        $ image1��57   
   $��295,195.5,305,126.5q�6   $��
light1.png��67   $
��Fill=�6K    J� Opacity$ 0.365Q�6Z   $y�Hidden=�6j   r� 58      -	   5         r�Name$( "Pingu__Igloo_Adventures___Clip_mp4��58      $%��742.333,518.334,178.334,148.166q�6=    r� Stretch$
 Fill=�6f   �� 59      -
   5        $ image2��59   
   $��737,507.5,150.5,139.145q�6   $��tv.png��6;   $
��Fill=�6K    � Cursor$
 Hand��6Z    J� SnapsToDevicePixels . 6h   �� 5:      -   5         ��Name$ label��5:   
   $��
OFF
��6   $
��Left=�6;   $��830.5,536.5,0,0q�6V   $	��Top=�6o   $��69.293��6�   $��28.91��6�   $��8(�6�   $
��Bold"�6�   $
 Hand��6�   5;      5<      