   M S B A M L   `   `   `  ����D  @Artisanal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Artisanal	Artisanal  5   	   '    !Artisanal.TableauDeBordProducteur   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Artisanal     5   	     � Title$  Tableau de bord��5   	   $	��450��6!   $��743.2��6.   .��5	      � $��0,0,0,2q�6   .+�5
   
   �� -   5         ��Name$ 
tabControl��5
      $
��Left=�6)   $	��250��6D   $��	10,34,0,0q�6Q   $	��Top=�6d   $	��375��6|   .@�5      �� $��Ajouter un produit��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5         ��Name$ nomProduitLbl��5      $��NomProduit :��63   $
��Left=�6J   $��	21,27,0,0q�6e   $	��Top=�6x    J� RenderTransformOrigin$ -0.359,-2.094&�6�   �� 5      -   5        $ prixLbl��5      $��Prix :��6-   $
��Left=�6>   $��	21,72,0,0q�6Y   $	��Top=�6l   �� 5      -   5         ��Name$ ajouterImageBtn��5      $��Ajouter Image��66   $
��Left=�6N   $��
21,149,0,0q�6i   $	��Top=�6}   $��98��6�   6�   �� 5      -   5         ��Name$ produitAAjoutertxt��5      $
��Left=�6:   $��23��6U   $��
118,31,0,0q�6a    �� TextWrapping$
 Wrap=�6u   $	��Top=�6�   $	��120��6�   �� 5      -   5        $ prixProduitAAjouter��5      $
��Left=�6;   $��23��6V   $��
118,76,0,0q�6b   $
 Wrap=�6v   $	��Top=�6�   $	��120��6�   �� 5      -   5         ��Name$ image��5      $
��Left=�6+   $	��100��6F   $��138,112,0,0q�6S   $	��Top=�6h   $	��100��6�   $ 	0.04,0.42&�6�   5      5      �� 5      $��supprimer un produit��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5        $ nomProduitASupprimerLbl��5      $��Nom produit��6=   $
��Left=�6S   $��	17,43,0,0q�6n   $	��Top=�6�   �� 5      -	   5        $ ProduitASupprimerTxt��5      $
��Left=�6<   $��23��6W   $��
105,45,0,0q�6c   $
 Wrap=�6w   $	��Top=�6�   $	��120��6�   6�   �� 5      -
   5        $ SupprimerProduitBtn��5      $��	Supprimer��6:   $
��Left=�6N   $��105,116,0,0q�6i   $	��Top=�6~   $��75��6�   6�   5      5      �� 5      $��modifier un produit��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5        $ nomProdAModifierTxt��5      $
��Left=�6;   $��23��6V   $��
142,60,0,0q�6b   $
 Wrap=�6v   $	��Top=�6�   $	��120��6�   �� 5      -   5        $ label��5      $��nom produit��6+   $
��Left=�6A   $��	41,60,0,0q�6\   $	��Top=�6o   �� 5       -   5        $ label1��5       $��nouveau prix��6,   $
��Left=�6C   $��
41,128,0,0q�6^   $	��Top=�6r   �� 5!      -   5        $ nouveauPrix��5!      $
��Left=�63   $��23��6N   $��142,132,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��120��6�   �� 5"      -   5        $ modifierBtn��5"      $��modifier prix��62   $
��Left=�6J   $��142,179,0,0q�6e   $	��Top=�6z   $��75��6�   6�   5$      5%      5&      5'      5(      