   M S B A M L   `   `   `  ����H  DEntitiesLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:EntitiesLayer;assembly=EntitiesLayerEntitiesLayer  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	    PokemonTournamentWPF(   "PokemonTournamentWPF.AjoutDresseur   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:EntitiesLayer;assembly=EntitiesLayer     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  AjoutDresseur��5
   	   $��441.167��6   $��267.378��60    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Icon$f `C:/Users/Thibault/Documents/Visual Studio 2015/Projects/PokemonTournamentConsole/Images/icon.ico��5   	    � 	Resources 5         dataFromEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%y   &	        S� 5   
   $ 	GetValues��62   "  6I    5      M� 5      $ local:ETypeElement��6   5      5      .��5      � $��0,0,0,16q�6   .+�5   
   �� -   5        	 ��Name$	 cancel��5      $��Annuler��6!   $
��Left=�63   $��	45,0,0,-5q�6N   $��Bottom=�6a   $��76��6|   6�   �� 5   
   -   5        $		 add��5      $��Ajouter��6   $��Right=�60   $��	0,0,40,-5q�6L   $��Bottom=�6_   $��74��6z   6�   �� 5   
   -   5        
 ��Name$
 nom_dresseur��5      $��22��6(   $��
47,10,40,0q�64   $	��Top=�6H   6`   �� 5   
   -   5        $
 bg_nom_dresseur��5      $��22��6+   $��
47,10,40,0q�67    �� TextWrapping$
 Wrap=�6K   $��Nom du Dresseur��6_   $	��Top=�6v   ���	#FF198BB06�   	� 5   
   -   5         	�Name$ radioYes��5       	� 	GroupName$ 
gotPokemon��6(   $	��Oui��6@   $
��Left=�6N   $��	83,63,0,0q�6i   $	��Top=�6|    d� 	IsChecked$
 TrueY�6�   6�   	� 5   
   -   5        $ radioNo��5      $ 
gotPokemon��6'   $	��Non��6>   $
��Left=�6L   $��
147,63,0,0q�6g   $	��Top=�6{   6�   �� 5   
   -   5         ��Name$ labelGotPokemon��5      $��DemiBold"�6-   $
��Left=�6C   $��	54,42,0,0q�6^   $
��Wrap=�6q   $$��Utiliser un Pokemon existant ?��6�   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ dataGrid_ajout_dresseur��5!         AutoGenerateColumns .     
IsReadOnly . $
��Left=�6b   $��
10,113,0,0q�6}   $	��Top=�6�   $	��253��6�   $	��241��6�      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+  5$      $	 Nom��6%    62   �� *Nom+  5%      $ Element��6%    66   �� *	Element+5'      �� 5(   
   -	   5        $ label_grid_gotPokemon��5(      $��DemiBold"�63   $
��Left=�6I   $��	64,92,0,0q�6d   $
��Wrap=�6w   $��Choisissez le Pokemon :��6�   $	��Top=�6�   �� 5*   
   -
   5        $ label_grid_noPokemon��5*      $��DemiBold"�62   $
��Left=�6H   $��	75,92,0,0q�6c   $
��Wrap=�6v   $��Créez le Pokemon :��6�   $	��Top=�6�   �� 5+   
   -   5        $
 fg_nom_pokemon��5+      $��22��6*   $��54,118,33,0q�66   $	��Top=�6K   6c   �� 5,   
   -   5        $
 bg_nom_pokemon��5,      $��22��6*   $��54,118,33,0q�66   $
 Wrap=�6K   $��Nom du Pokemon��6_   $	��Top=�6u   ���	#FF198BB06�   �� 5.   
   -   5         ��Name$ cb_Elem��5.       �� SelectedIndex$ 0��6$    �� 
IsEditable .  �� 
IsReadOnly . $��54,146,33,0q�6Z   $	��Top=�6o   ��5/      -  'System.Windows.Data.CompositeCollection  50      �� 51      .��6"   
Elément6+   �� 52       �� 
Collection 6*   ��  �� Source# [  53      55      �� 56   
   -   5        $ caract��56      $
��Left=�6$   $��
88,180,0,0q�6?   $
��Wrap=�6S   $��Caractéristiques��6g   $��	Underline{�6   $	��Top=�6�   �� 58   
   -   5        $
 life��58      $
��Left=�6"   $��
50,216,0,0q�6=   $
��Wrap=�6Q   $��Vie : ��6e   $	��Top=�6s   �� 59   
   -   5        $
 life2��59       �� 
IsReadOnly . $��81,208,143,156q�6�   ��6!   ��  �� ElementName$	 vie�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5:   
   -   5          ��Name$	  vie��5:      ! � Minimum$! 10Q�6   " � Maximum$	" 100Q�6+   # �� TickPlacement$# BottomRight=�69   $ �� TickFrequency$$ 5Q�6U   % �� IsSnapToTickEnabled% . $
��Left=�6�   $��121,208,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 5<   
   -   5        $	 str��5<      $
��Left=�6!   $��
38,262,0,0q�6<   $
��Wrap=�6P   $��Force : ��6d   $	��Top=�6t   & J� RenderTransformOrigin$& 1.632,2.375&�6�   �� 5=   
   -   5        $

 str2��5=       . $��79,254,145,110q�6�   ��6    �� $ force��$ Value�$ PropertyChanged=�6�   �� 5>   
   -   5        $  force��5>      $! 10Q�6    $	" 100Q�6-   $# BottomRight=�6;   $$ 5Q�6W   % . $
��Left=�6�   $��121,254,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 5@   
   -   5        $	 dex��5@      $
��Left=�6!   $��
33,302,0,0q�6<   $
��Wrap=�6P   $��Agilité : ��6d   $	��Top=�6v   �� 5A   
   -   5        $

 dex2��5A       . $��79,294,145,70q�6�   ��6    �� $ agilite��$ Value�$ PropertyChanged=�6�   �� 5B   
   -   5        $  agilite��5B      $! 10Q�6"   $	" 100Q�6/   $# BottomRight=�6=   $$ 5Q�6Y   % . $
��Left=�6�   $��121,294,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 5D   
   -   5        $ intel��5D      $
��Left=�6#   $��	6,344,0,0q�6>   $
��Wrap=�6Q   $��Intelligence : ��6e   $	��Top=�6|   �� 5E   
   -   5        $
 intel2��5E       . $��79,336,145,28q�6�   ��6"   �� $ intelligence��$ Value�$ PropertyChanged=�6�   �� 5F   
   -   5        $  intelligence��5F      $! 10Q�6'   $	" 100Q�64   $# BottomRight=�6B   $$ 5Q�6^   % . $
��Left=�6�   $��121,336,0,0q�6�   $	��Top=�6�   $	��130��6�   A� 5G   
   ���	#FFF4F4F5$��Center=�6#   $��1��6@   $��
11,85,11,0q�6K   
���   �$	��Top=�6n   $	��239��6�   $& 0.5,0.5&�6�   z�5H      V� 5I      .~�5J      �� ' �� ScaleY$' -1Q�6%   �� 5K      �� 5L      T� 5M      5N      5P      5U      5V      