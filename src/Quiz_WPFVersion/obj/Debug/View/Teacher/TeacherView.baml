   M S B A M L   `   `   `  ����J  FQuiz_WPFVersion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Quiz_WPFVersion.View.TeacherQuiz_WPFVersion.View.Teacher  5      .    (Quiz_WPFVersion.View.Teacher.TeacherView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Quiz_WPFVersion.View.Teacher     5        N� Title$  TeacherView��5       � 	Resources 5	         DataTemplate1  	fontColor��%�   &	        �� 5
   
   .R�5      � .+�5      �� #���  6I   ��6   �� *Title+��63   Z� 6I   5      5      5      .��5      �   backgroundOrangeLight#��[ 6   $��0,0,0,0q�6?   .+�5   
   � $��20,20q�6    � RowDefinitions 5      �� 5      $��24 �6    �� 5      $��18 �6    �� 5      $��25 �6    �� 5      $��17 �6    �� 5      $��17 �6    �� 5      $��2* �6    �� 5       � ColumnDefinitions 5      �� 5      $��90 �6#   �� 5      $��12 �6#   �� 5       $	��197 �6#   .+�5$      �� -   5         ��Name$ txtb_labelWelcome��5$      $
��Wrap=�63   $��Welcome��6G   $��16(�6V   
���   �$
��Bold"�6w   $��0,4,0,0q�6�   �� 5&      -   5        $ txtbName��5&      $��	0,5,-3,-2q�6*   $
��Wrap=�6=   $��Ingemo Illander��6Q   
���   �$��16(�6{   $!��Microsoft JhengHei UI Light)�6�   $��Light"�6�   $��2��6�   �� 5(      -   5        $ txtb_labelAcess��5(      $
��Wrap=�61   $��Qualification:��6E   $��14(�6\   $��Segoe WP Light)�6j   $��Italic$�6�   #��[ 6�   $
��Thin"�6�   $��1��6�   $��2��6�   �� 5*      -   5        $ 	txtbAcess��5*      $��Teacher��6-   $��14(�6<   $��Segoe WP Light)�6J   #��[ 6f   $
��Thin"�6�   $��1��6�   $��2��6�   �� 5.      -   5        $ textBlock_Copy��5.      #��[ 60   $��14(�6X   $��Segoe UI Symbol)�6f    �� TextAlignment$ Justify=�6�   $��Sample to pass on��6�   $��4��6�   $��0,-7,9,1q�6�   $
��Wrap=�6�   $��3��6�   �� 5/      -   5         ��Name$ quizListBox��5/      $��5��6+   $��-1,0,-142,9.143q�6e   $��3��6~   #���   6�    � ToolTip$$ Samples sent to administrator.��6�   ��68   Z� ��6O   Z� ��50      �� 51       �� Color$ White��6&   	 �� Opacity$	 0.565Q�64   53      �� 56      -   5        
 ��Name$
 btnSingelQuestion��56        MyButtonStyle#��[ 60   $��10,0,0,0q�6W   $��6��6i   $��33��6�   $ Skicka prov��6�   $��41.12��6�   $	��Top=�6�   $
��Left=�6�   ��57      �� 58      .R�59      �� .+�5:      �� $��Segoe MDL2 Assets)�6)   $	����6H   $��20(�6X   $��Center=�6f   $��Center=�6�   #���  6�   ��6�   Z� 6�   �� 5;      $	��0,0q�6(   #���  65   $��Center=�6^   $��Center=�6{   $
��Send��6�   5<      5=      5?      �� 5@      -   5         ��Name$ 
lblMessage��5@      $
��Left=�6(   $��	-38,0,0,0q�6C   $��6��6V   $	��Top=�6c   $��2��6{   $	��195��6�   #���  6�   $
��28.8��6�   $��1��6�   5C      5D      5E      