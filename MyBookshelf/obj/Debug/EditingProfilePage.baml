   M S B A M L   `   `   `  ����F  BMyBookshelf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MyBookshelfMyBookshelf  5      $    MyBookshelf.EditingProfilePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:MyBookshelf     5        N� Title$  EditingProfilePage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��15* �6   �� 5      $��1* �6   �� 5      $	��20* �6   �� 5      $��1* �6   �� 5      $	��10* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��6* �6   �� 5      $
��Auto �6   �� 5      $��6* �6   �� 5      $
��Auto �6   �� 5      $��6* �6   �� 5      $
��Auto �6   �� 5      $��6* �6   �� 5      $��6* �6   �� 5      $��6* �6   .+�5    
   �� ���	#FFD38377$��2��6%   $��9��69   $
��Auto��6J   �� 5!   
   ���	#FFE8C6C8$��9��6%   $
��Auto��66   $��2��6E   $��5��6U   �� 5"   
   $��1��6   $��1��6$   $��	User name��61   $��
Trajan Pro)�6B   $��28(�6Z   ���	#FF5E08086h   �� 5#   
   $��1��6   $��3��6$   $��Password��61   $��
Trajan Pro)�6A   $��28(�6Y   ���	#FF5E08086g   �� 5$   
   $��1��6   $��5��6$   $��Date of birth��61   $��
Trajan Pro)�6F   $��28(�6^   ���	#FF5E08086l   �� 5%   
   -   5         ��Name$ save_profile��5%      $��Save changes��6'   $��5��6>   $��7��6N   ���	#FF7E0707$��Tempus Sans ITC)�6�   $��26(�6�   ��6v   Z� ��6�   Z� 6�   �� 5&   
   -   5         ��Name$ 	text_name��5&      $��3��6%   $��3��69   $��1��6I    J� Opacity$	 0.6Q�6V   ���	#FF5E0808$��
Trajan Pro)�6�   $��28(�6�    �� SelectionBrush 6{   Z� ��6�   Z� 6�   G� 5'   
   -   5         G�Name$ password_box��5'      $��3��6,   $��3��6@   $��3��6P   $	 0.6Q�6]   ���	#FF5E0808$��
Trajan Pro)�6�   $��28(�6�    G� SelectionBrush 6�   Z� ��6�   Z� 6�   (  "System.Windows.Controls.DatePicker  5(   
   -   5        	  Name$	 
birth_date��5(      $��3��6)   $��3��6=   $��5��6M   $	 0.6Q�6Z   ���	#FF5E0808$��
Trajan Pro)�6�   $��28(�6�   ��6   Z� 6�   5)      5*      