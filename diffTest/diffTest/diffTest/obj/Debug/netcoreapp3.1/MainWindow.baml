   M S B A M L   `   `   `  ����C  ?diffTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:diffTest.ViewsdiffTest.Views  5   	       diffTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .viewsclr-namespace:diffTest.Views     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 SolidButtonStyle �� 
TargetType �� 
TargetType	 ��Name
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $ 	#33808080��6;   �� 5   
   $ 	#44808080��67   �� 5   
   $ 	#990099FF��6>   �� 5   
   $ 	#CC0099FF��6:   �� 5   
   $ 	#EE0099FF��6<   �� 5   
   $ 	#FF0099FF��68   �� 5   
   $ 	#99808080��6=   �� 5   
   $ 	#CC808080��69   �� 5   
   $ 	#FF808080��6=   �� 5   
   " ��6)   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   ._�5)      �� $
 contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5B      �  � RowDefinitions 5C   
   �� 5D      $��30 �6   �� 5E      .+�5G   
   �� -   5         ��Name$ 	ActionBar��5G      ���	#20808080 �� Orientation$ 
Horizontal=�6?   $��Stretch=�6X   $��Stretch=�6v   .+�5H      �� -   5        $ 	MenuPanel��5H      $ 
Horizontal=�6,   $��0q�6E   6S   �� 5I      $ 
Horizontal=�6   $��	16,0,16,0q�62   .+�5J      �� -   5         ��Name$ OpenFileButton��5J   \   #��� 
 6   $	��100��6D   $��20��6P   $��	Open File��6t   $��0,0,16,0q�6�   ��6�   �� *
Foreground+ �� ElementName$ 
MainWindow�� � ContextMenu 5K      �� 5L      -   5         ��Name$ OpenFileContextMenu��5L   &   .@�5M      m� -   5         m�Name$ OpenLeftFileMenuItem��5M   '   $
��Left��6E   6S   m� 5N      -   5        $ OpenRightFileMenuItem��5N   '   $��Right��6F   6U   5O      5Q      �� 5R      -   5        $ 
DiffButton��5R   1   $	��120��6   $��20��6%   $��Switch Mode��6E   $��0q�6�   #��� 
 6�   ��6t   �� *
Foreground+$ 
MainWindow��6�   �� 5S      -   5        $ FurtherActionsButton��5S   0   $��20��6   $��20��6$   $	��…��6N   $��1,0,15,0q�6�   #��� 
 6�   ��6}   �� *
Foreground+$ 
MainWindow��6�   �� 5T      -	   5         ��Name$ 	GoToLabel��5T      $��20��6+   $��0q�67   $��16,0,8,0q�6C   $��Center=�6U   ��6w   �� *
Foreground+$ 
MainWindow��.��6�   Go to6�   �� 5U      -
   5         ��Name$ GoToText��5U   S   $��80��6   $��20��6%   $��Center=�61   $��8,0,8,0q�6e   $�� ��6w   $��0,0,8,0q�6	  ��6   �� *
Foreground+$ 
MainWindow�� �� 
CaretBrush 6�   �� *
Foreground+$ 
MainWindow����6�   Z� 6=  �� 5V      -   5        $ 
NextButton��5V   0   $��20��6   $��20��6$   $��0,0,1,0q�6�   #��� 
 6�   ��6]   �� *
Foreground+$ 
MainWindow��.��5W      F� $��10��6   $��10��6&    �� Stretch$
 Fill=�62   +����    @B � 	=  z �@KL  z �@T� @B 	��6A   �� *
Foreground+$ 
MainWindow��6w   5X      �� 5Y      -   5        $ PreviousButton��5Y   0   $��20��6   $��20��6$   $��0q�6�   #��� 
 6�   ��6e   �� *
Foreground+$ 
MainWindow��.��5Z      F� $��10��6   $��10��6&   $
 Fill=�62   +����     z � 	= @B �@KL @B �@T�  z 	��6A   �� *
Foreground+$ 
MainWindow��6w   5[      5\      �� 5]      -   5        $ AdditionalMenuPanel��5]      $ 
Horizontal=�66   $��0q�6O   6]   5^         diffTest.Views.DiffViewer  5_   
   -   5          Name$ DiffView��5_      $��Stretch=�6-   $��Stretch=�6K   $��0,0,0,0q�6g   $��1��6�   ��6x   �� *
Foreground+$ 
MainWindow��6�   5`      5a      