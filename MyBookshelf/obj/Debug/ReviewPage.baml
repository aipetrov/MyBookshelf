   M S B A M L   `   `   `  ����F  BMyBookshelf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MyBookshelfMyBookshelf  5          MyBookshelf.ReviewPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:MyBookshelf     5        N� Title$  
ReviewPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $	��14* �6   �� 5      $	��18* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $	��14* �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      $	��15* �6   �� 5      $��2* �6   �� 5      $	��15* �6   �� 5      $��2* �6   �� 5      $	��15* �6   �� 5       $��2* �6   .+�5"   
   �� ���	#FFD38377$��4��6%   $��11��69   $
��Auto��6K   �� 5#   
   ���	#FFE8C6C8$��11��6%   $
��Auto��67   $��4��6F   $��3��6V   �� 5$   
   -   5         ��Name$ list_reviews��5$      $��1��6(   $��7��68   $��2��6E   $��3��6Y    J� Opacity$	 0.6Q�6j   ���	#FF5E0808$��
Trajan Pro)�6�   $��20(�6�   ��6�   Z� ��5%      �� 5&      .R�5'      � $��1��6   $��7��6+   $��2��68   $��3��6L   $	��400��6]   $	��220��6l    5(      �� 5)      $��1* �6/   �� 5*      $	��10* �6/   �� 5+      $��1* �6/   �� 5,      $	��10* �6/   �� 5-      $��6* �6/   �� 5.      $��3* �6/   �� 5/      $��2* �6#   �� 50      $��1* �6#    52      �� 53      $��1* �6,   �� 54      $
��Auto �6,   �� 55      $��1* �6,   �� 56      $��8* �6,   �� 57      $��1* �6,   .+�59      �� $��1��6?   $��1��6O   $��12(�6\   $��Blogger Sans)�6j   ���	#FF5E0808$
��Bold"�6�   ��6$   �� *	User.Name+6�   �� 5:      $��3��6>   $��1��6N   $��9(�6[   $��Blogger Sans)�6h   ���	#FF9C9191��6$   �� *
DateTime+6�   �� 5;      $��Rating:��6$   $��5��63   $��1��6C   $��10(�6P   $��Blogger Sans)�6^   ���	#FF5E0808$
��Bold"�6�   �� 5<      $��6��6<   $��1��6L   $��10(�6Y   $��Blogger Sans)�6g   ���	#FF5E0808$
��Bold"�6�   ��6$   �� *Rating+6�   �� 5=      $��1��6=   $��6��6M   $��3��6a   $��10(�6n   $��Blogger Sans)�6|   ���	#FF5E0808��6$   �� *	Comment+6�   5>      5?      5A      �� 5B   
   -   5         ��Name$ send_review��5B      $��Send review��6&   $��5��6<   $��5��6L   ���	#FF7E0707$��Tempus Sans ITC)�6�   $��30(�6�   ��6Y   Z� ��6o   Z� 6�   �� 5C   
   -   5         ��Name$ write_review��5C       �� TextWrapping$
 Wrap=�6(   $��1��6<   $��2��6L   $��3��6`   $��3��6m   $	 0.6Q�6~   ���	#FF5E0808$��
Trajan Pro)�6�   $��20(�6�    �� SelectionBrush 6�   Z� ��6�   Z� 6�   �� 5D   
   -   5        	 ��Name$	 textblock_book��5D      $��Name of the book��6,   $��1��6D   $��1��6T   $��2��6a   $��Center=�6u   $��
Trajan Pro)�6�   ���	#FF5E0808$��22(�6�   �� 5E   
   -   5        
 ��Name$
 rating_combobox��5E   "    �� Text$ Rating:��6   $��5��6;   $��3��6K   .@�5F      �� $��1��6   6)   �� 5G      $��2��6   6)   �� 5H      $��3��6   6)   �� 5I      $��4��6   6)   �� 5J      $��5��6   6)   5K      �� 5L   
   -   5        $ edit_review��5L      $��Edit review��6&   $��5��6<   $��7��6L   ���	#FF7E0707$��Tempus Sans ITC)�6�   $��30(�6�   {�.  ��6s   Z� ��6�   Z� 6�   �� 5M   
   -   5        $ delete_review��5M      $��Delete review��6(   $��5��6@   $��9��6P   ���	#FF7E0707$��Tempus Sans ITC)�6�   $��30(�6�   {�.  ��6]   Z� ��6s   Z� 6�   5N      5O      