   M S B A M L   `   `   `  ����C  ?diffTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:diffTest.ViewsdiffTest.Views  5          diffTest.Views.DiffViewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:diffTest.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      -   5         ��Name$ 	HeaderRow��5      $��0 �6/   �� 5      -   5        $ 
ContentRow��5      $��* �60    � ColumnDefinitions 5   
   �� 5      -   5         ��Name$ 
LeftColumn��5      �� 5      -   5        $ RightColumn��5      .+�5   
   �� -   5         ��Name$ HeaderBorder��5      $��Stretch=�6'   $��Stretch=�6E   $��2��6a    � ContextMenu 5      �� 5      -   5         ��Name$ HeaderContextMenu��5      .@�5      m� -   5         m�Name$ InlineModeToggle��5      $��_Unified view��69   6P   m� 5      -   5        $ SideBySideModeToggle��5      $��_Split view��6=    m� 	IsChecked$
 True��6u   �� 5      m� 5      -	   5        $% CollapseUnchangedSectionsToggle��5      $"��_Collapse unchanged sections��6H   6n   m� 5      -
   5        $ ContextLinesMenuItems��5      $��_Lines for context��6>   $y�	Collapsed=�6Z   .@�5      m� -   5        $��_0��5   #   6/   m� 5      -   5        $��_1��5   #   6/   m� 5      -   5        $��_2��5   #   6/   m� 5      -   5        $��_3��5   #   6/   m� 5      -   5        $��_4��5   #   6/   m� 5      -   5        $��_5��5   #   6/   m� 5       -   5        $��_6��5    #   6/   m� 5!      -   5        $��_7��5!   #   6/   m� 5"      -   5        $��_8��5"   #   6/   m� 5#      -   5        $��_9��5#   #   6/   m� 5$      -   5        $# CustomizedContextLineMenuItem��5$   #   $��_X��6J   $y�	Collapsed=�6x   5%      5&      5(      �� 5)   
   -   5        	 ��Name$	 InlineHeaderText��5)      $��Center=�6.   $��Center=�6K   $��2��6f   $y�	Collapsed=�6z   (   "diffTest.Views.InternalLinesViewer  5*   
   -   5        
  Name$
 InlineContentPanel��5*   $   $��2��6@   $��1��6T   $y�	Collapsed=�6a   �� 5+   
   -   5        $	 LeftHeaderText��5+      $��Center=�6,   $��Center=�6I     5,   
   -   5        $
 LeftContentPanel��5,   $   (   "diffTest.Views.InternalLinesViewer   ScrollChanged$$ LeftContentPanel_ScrollChanged��6>   $��1��6m   �� 5-   
   -   5         ��Name$ Splitter��5-      $��5��6)   $��2��63   �� 5.   
   -   5        $	 RightHeaderText��5.      $��Center=�6-   $��Center=�6J   $��1��6e     5/   
   -   5        $
 RightContentPanel��5/   $   $% RightContentPanel_ScrollChanged��6?   $��1��6o   $��1��6|   50      51      