   M S B A M L   `   `   `  ����H  DEntitiesLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:EntitiesLayer;assembly=EntitiesLayerEntitiesLayer  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	    PokemonTournamentWPF'   !PokemonTournamentWPF.AjoutPokemon   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:EntitiesLayer;assembly=EntitiesLayer     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ AjoutPokemon��5
   	   $��329.167��6   $��267.378��6/    � 
ResizeMode$ NoResize=�5   	    � Icon$f `C:/Users/Thibault/Documents/Visual Studio 2015/Projects/PokemonTournamentConsole/Images/icon.ico��5   	    � 	Resources 5         dataFromEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%y   &	        S� 5   
   $ 	GetValues��62   "  6I    5      M� 5      $ local:ETypeElement��6   5      5      .��5      � .+�5   
   �� -   5        	 ��Name$	 cancel��5      $��Annuler��6!   $
��Left=�63   $��48,0,0,5q�6N   $��Bottom=�6`   $��76��6{   6�   �� 5   
   -   5        $		 add��5      $��Ajouter��6   $��Right=�60   $��0,0,48,5q�6L   $��Bottom=�6^   $��74��6y   6�   �� 5   
   -   5        
 ��Name$
 fg_nom_pokemon��5      $��22��6*   $��
47,10,40,0q�66   $	��Top=�6J   6b   �� 5   
   -   5        $
 bg_nom_pokemon��5      $��22��6*   $��
47,10,40,0q�66    �� TextWrapping$
 Wrap=�6J   $��Nom du Pokemon��6^   $	��Top=�6t   ���	#FF198BB06�   �� 5   
   -   5         ��Name$ cbElem��5       �� SelectedIndex$ 0��6#    �� 
IsEditable .  �� 
IsReadOnly . $��
47,37,40,0q�6Y   $	��Top=�6m   ��5      -  'System.Windows.Data.CompositeCollection  5      �� 5       .��6"   
Elément6+   �� 5!       �� 
Collection 6*   ��  �� Source# [  5"      5$      �� 5%   
   -   5         ��Name$ caract��5%      $
��Left=�6$   $��	86,76,0,0q�6?   $
��Wrap=�6R   $��Caractéristiques��6f   $��	Underline{�6~   $	��Top=�6�   �� 5'   
   -   5        $
 life��5'      $
��Left=�6"   $��
48,111,0,0q�6=   $
��Wrap=�6Q   $��Vie : ��6e   $	��Top=�6s   �� 5(   
    �� 
IsReadOnly . $��79,103,145,163q�6v   ��6   ��  �� ElementName$	 vie�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6v   �� 5)   
   -   5         ��Name$	 vie��5)       � Minimum$ 10Q�6    � Maximum$	 100Q�6+    �� TickPlacement$ BottomRight=�69    �� TickFrequency$ 5Q�6U    �� IsSnapToTickEnabled . $
��Left=�6�   $��119,103,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 5+   
   -	   5        $	 str��5+      $
��Left=�6!   $��
36,157,0,0q�6<   $
��Wrap=�6P   $��Force : ��6d   $	��Top=�6t    J� RenderTransformOrigin$ 1.632,2.375&�6�   �� 5,   
    . $��79,149,145,117q�6x   ��6   �� $ force��$ Value�$ PropertyChanged=�6x   �� 5-   
   -
   5        $ force��5-      $ 10Q�6    $	 100Q�6-   $ BottomRight=�6;   $ 5Q�6W    . $
��Left=�6�   $��119,149,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 5/   
   -   5        $	 dex��5/      $
��Left=�6!   $��
31,197,0,0q�6<   $
��Wrap=�6P   $��Agilité : ��6d   $	��Top=�6v   �� 50   
    . $��79,189,145,77q�6z   ��6   �� $ agilite��$ Value�$ PropertyChanged=�6z   �� 51   
   -   5        $ agilite��51      $ 10Q�6"   $	 100Q�6/   $ BottomRight=�6=   $ 5Q�6Y    . $
��Left=�6�   $��119,189,0,0q�6�   $	��Top=�6�   $	��130��6�   �� 53   
   -   5        $ intel��53      $
��Left=�6#   $��	4,239,0,0q�6>   $
��Wrap=�6Q   $��Intelligence : ��6e   $	��Top=�6|   �� 54   
    . $��79,231,145,35q�6   ��6   �� $ intelligence��$ Value�$ PropertyChanged=�6   �� 55   
   -   5        $ intelligence��55      $ 10Q�6'   $	 100Q�64   $ BottomRight=�6B   $ 5Q�6^    . $
��Left=�6�   $��119,231,0,0q�6�   $	��Top=�6�   $	��130��6�   58      59      