   M S B A M L   `   `   `  ����  TangibleStories$    TangibleStories.SurfaceWindow1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      e aMicrosoft.Surface.Presentation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e351s)http://schemas.microsoft.com/surface/2008  5      -   5          � Title$  TangibleStories��5      .��5      � ��5   
   �� 5       j� Stretch$ UniformToFill=�6    �� ImageSource$2 ,/TangibleStories;component/Resources/map.png��61   .+�5   
   ;  5Microsoft.Surface.Presentation.Controls.TagVisualizer  -   5           Definitions 5      H  BMicrosoft.Surface.Presentation.Controls.TagVisualizationDefinition  5         Value<  6Microsoft.Surface.Presentation.Input.TagValueConverter$	 0x1 6/     5      $	 0x2 6/   5      ;  5Microsoft.Surface.Presentation.Controls.SurfaceButton  5   
   -   5        $��CanadaButton��5      
������ $��0,0,700,300q�5      $	��300��5   5   $	��300��6B     5   
   -   5        $��USButton��5      
������ $��
0,80,700,0q�5      $	��200��5   1   $	��100��6=     5   
   -   5        $��TCButton��5      
������ $��0,200,500,0q�5      $	��100��5   1   $	��100��6=     5    
   -   5        $��EcuadorButton��5       
������ $��0,340,600,0q�5"      $��15��5#   6   $��15��6A     5$   
   -   5        $��
PeruButton��5$      
������ $��0,420,580,0q�5&      $��20��5'   3   $��50��6>     5)   
   -   5        $��AustriaButton��5)      
������ $��0,0,0,0q�5+      $��5��5,   6   $��5��6@     5-   
   -	   5        $��SwitzerlandButton��5-      
������ $��0,0,20,0q�5/      $��5��50   :   $��5��6D     51   
   -
   5        $��FranceButton��51      
������ $��0,0,75,0q�53      $��30��54   5   $��40��6@     55   
   -   5        $��ItalyButton��55      
������ $��	10,53,0,0q�57      $��10��59      $��45��6%     5:   
   -   5        $��GermanyButton��5:      
������ $��	0,0,20,50q�5<      $��20��5=   6   $��40��6A     5>   
   -   5        $��UKButton��5>      
������ $��
0,0,100,70q�5@      $��20��5A   1   $��50��6<     5B   
   -   5        $��NorwayButton��5B      
������ $��	0,0,0,230q�5D      $��50��5E   5   $	��120��6@   �� 5F   
   $��40q�6   .+�5G      @  :Microsoft.Surface.Presentation.Controls.SurfaceRadioButton  -   5          Name$ hideInfo��5G   #   $��Hide Trip Info��65    	� 	GroupName$
 Info��6N    d� 	IsChecked$ FalseY�5H   >     5I      -   5        $ showInfo��5I   #   $��Show Trip Info��65   $
 Info��6N   $
 TrueY�5J   >   5K        5L   
   -   5        $��ClearButton��5L      $y�Hidden=�5M      $��Clear��5N      $��1200,600,0,0q�5O      $	��100��5P   1   $��50��6=   �� 5Q   
   -   5        $��TripInfo��5Q      $��0,500,1100,0q�5R      $	��250��5S      $	��500��6   �� 5T   
   -   5        $��Description��5T      $y�Hidden=�5U      $��0,450,1100,0q�5V      $	��225��5W      $	��250��6   
�������5X      9  3Microsoft.Surface.Presentation.Controls.ScatterView  5Z   
   -   5          Name$ scatter��5Z      $��2,32,-2,-32q�6)   ��5[      �� 5\      .R�5]      � .+�5^      �� 	 ��Name$		 img��6    ��6-   �� 5_      5`      5b      5c      5d      