   M S B A M L   `   `   `  ����H  DEntitiesLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:EntitiesLayer;assembly=EntitiesLayerEntitiesLayer  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	    PokemonTournamentWPF%   PokemonTournamentWPF.AjoutStade   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:EntitiesLayer;assembly=EntitiesLayer     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ 
AjoutStade��5   	   $��329.167��6   $��274.878��6-    � Icon$f `C:/Users/Thibault/Documents/Visual Studio 2015/Projects/PokemonTournamentConsole/Images/icon.ico��5   	    � 	Resources 5         dataFromEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%y   &	        S� 5   
   $ 	GetValues��62   "  6I    5      M� 5      $ local:ETypeElement��6   5      5      .��5      � .+�5   
   �� -   5        	 ��Name$		 nom��5      $��Center=�6   $��23��6<   $��
63,10,63,0q�6H   $	��Top=�6\   $	��118��6t   6�   �� 5   
   -   5        $	 bg_nom��5      $��Center=�6"   $��23��6?   $��
63,10,63,0q�6K   $	��Top=�6_   $	��125��6w   $��Nom du stade��6�   ���	#FF198BB0
�������5   1   �� 5   
   -   5        
 ��Name$
 
cbElem_add��5       �� SelectedIndex$ 0��6'    �� 
IsEditable .  �� 
IsReadOnly . $��
66,38,67,0q�6]   $	��Top=�6q   ��5      -  'System.Windows.Data.CompositeCollection  5      �� 5       .��6"   
Elément6+   �� 5!       �� 
Collection 6*   ��  �� Source# [  5"      5$      �� 5&   
   -   5         ��Name$ caract��5&      $
��Left=�6$   $��	79,94,0,0q�6?   $
��Wrap=�6R   $��Caractéristiques��6f   $��	Underline{�6~   $	��Top=�6�   �� 5(   
   -   5        $
 life��5(      $
��Left=�6"   $��
53,121,0,0q�6=   $
��Wrap=�6Q   $��Vie : ��6e   $	��Top=�6s   �� 5)   
    �� 
IsReadOnly . $��79,121,153,153q�6v   ��6   ��  �� ElementName$	 vie�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6v   �� 5*   
   -   5         ��Name$	 vie��5*       � Minimum$	 -10Q�6    � Maximum$ 10Q�6,    �� TickPlacement$ BottomRight=�69    �� TickFrequency$ 1Q�6U    �� IsSnapToTickEnabled . $
��Left=�6�   $��119,121,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 5,   
   -   5        $	 str��5,      $
��Left=�6!   $��
41,157,0,0q�6<   $
��Wrap=�6P   $��Force : ��6d   $	��Top=�6t    J� RenderTransformOrigin$ 1.632,2.375&�6�   �� 5-   
    . $��79,156,153,117q�6x   ��6   �� $ force��$ Value�$ PropertyChanged=�6x   �� 5.   
   -   5        $ force��5.      $	 -10Q�6    $ 10Q�6.   $ BottomRight=�6;   $ 1Q�6W    . $
��Left=�6�   $��119,157,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 50   
   -	   5        $	 dex��50      $
��Left=�6!   $��
36,198,0,0q�6<   $
��Wrap=�6P   $��Agilité : ��6d   $	��Top=�6v   �� 51   
    . $��79,197,153,77q�6z   ��6   �� $ agilite��$ Value�$ PropertyChanged=�6z   �� 52   
   -
   5        $ agilite��52      $	 -10Q�6"   $ 10Q�60   $ BottomRight=�6=   $ 1Q�6Y    . $
��Left=�6�   $��119,197,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 54   
   -   5        $ intel��54      $
��Left=�6#   $��
10,232,0,0q�6>   $
��Wrap=�6R   $��Intelligence : ��6f   $	��Top=�6}   �� 55   
    . $��79,231,153,43q�6   ��6   �� $ intelligence��$ Value�$ PropertyChanged=�6   �� 56   
   -   5        $ intelligence��56      $	 -10Q�6'   $ 10Q�65   $ BottomRight=�6B   $ 1Q�6^    . $
��Left=�6�   $��119,231,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 58   
   -   5         ��Name$ cancel��58      $��Annuler��6!   $
��Left=�63   $��48,0,0,5q�6N   $��Bottom=�6`   $��76��6{   6�   �� 59   
   -   5        $	 add��59      $��Ajouter��6   $��Right=�60   $��0,0,48,5q�6L   $��Bottom=�6^   $��74��6y   6�   �� 5;   
   -   5        $ slider_place��5;      $
 1000Q�6(   $ 25000Q�67   $ BottomRight=�6G   $	 500Q�6c    . $
��Left=�6�   $��
119,65,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 5<   
    . $��66,65,153,209q�6   ��6   �� $ slider_place��$ Value�$ PropertyChanged=�6   �� 5=   
   -   5        $ place��5=      $
��Left=�6#   $��	10,65,0,0q�6>   $
��Wrap=�6Q   $��	Places : ��6e   $	��Top=�6v   5?      5@      