   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  
MainWindow??5   	   $
??1080??6   $
??1920??6*    ? WindowState$ 	Maximized=?5	   	    ? WindowStyle$
 None=?5
   	   ???	#FF171731.??5      ?  ? IsSharedSizeScope$
 True??6    ? RowDefinitions 5   
   ?? 5      6   ?? 5      $	??850 ?6   6+   .+?5   
   ?? $@??:E:\MainProjectArcadeGame\WpfApp1\Images\logomainscreen.png??6   $??Center=?6T   ? 5   
   $??1??6    ? ColumnDefinitions 5      ?? 5      6%   ?? 5      $??3* ?6#   60   .+?5      ?? $??1??6   $^??XE:\MainProjectArcadeGame\WpfApp1\Images\ddtthe5-f1ce4f26-fdf0-400c-b8e2-2ab8b14c8ac7.png??6$   $
??Fill=?6?   ?? 5      $??Center=?6   $??Center=?66   .+?5      ?? -   5         ??Name$ 
PlayButton??5!      $??0??5      $??Arial Black)?5      $??60(?5      ???	#FF31315B$??3q?5      
????iA?$	??400??5      $	??150??6%   $
??Play??5       5!   -   ?? 5"      -   5        $ HighScoreButton??5*      $??0??5"      $??Arial Black)?5#      $??60(?5$      ???	#FF31315B$??3q?5&      
????iA?$	??400??5(      $	??150??6%   $??
High Score??5)      5*      ?? 5+      -   5        $ SettingsButton??53      $??0??5+      $??Arial Black)?5,      $??60(?5-      ???	#FF31315B$??3q?5/      
????iA?$	??400??51      $	??150??6%   $??Settings??52      53      ?? 54      -   5        $ 
QuitButton??5<      $??0??54      $??Arial Black)?55      $??60(?56      ???	#FF31315B$??3q?58      
????iA?$	??400??5:      $	??150??6%   $
??Quit??5;      5<   -   5=      ?? 5>      .+?5?   
   ?? .+?5@      ?? -   5         ??Name$ 	NameLabel??5A      $?? ??5B      $
??Bold"?5C      
????  ?5D      ?? 5E      -   5         ??Name$ MainTextBox??5F      $??200px??5G      $??10q?5H      $
??Left=?5I      ?? 5J      -   5        $ NameInputButton??5K      $	??100??5L      $??10q?5M      $
??Left=?5N      $??Naam toevoegen??5O      5P      5S      5T      5U      5V      5W      