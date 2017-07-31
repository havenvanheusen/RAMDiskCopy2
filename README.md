# RAMDiskCopy2

Download the latest version here: https://github.com/havenvanheusen/RAMDiskCopy2/releases/download/1.0.0/RAMDiskCopy2.exe

Creates a RAM disk and copies specified files to it leaving a symbolic link so that it may be accessed as if it never left all while leaving a backup copy of the files behind in case disaster strikes and your RAM disk goes bye-bye. This version does not have the ability to copy files back from the RAMDisk to your normal storage device (though this is planned).

This is a rewrite of my original RAMDiskCopy program. I wanted something with more versatility so I could pick and choose the files that I wanted to send to the RAMDisk. This is useful for games that won't all fit into a RAMDisk or for setting commonly used files from multiple locations to the RAMdisk. The big new feature of this version is the ability to save the settings for the RAMDisk to file so you don't have to go digging around your program directories more than once if you don't want to. Useful for having a different RAMDisk setup for different situations.

Works great for Steam games, virtual machines and many other uses. Won't work on your Windows folder, though. There are safeguards in place for that, but I wouldn't recommend trying to circumvent them.

This is another early project for me, so even though I've come a long way since the first iteration of RAMDiskCopy, things are still a bit amature and messy.

This program relies on ImDisk Toolkit to be installed to create the RAM disks. It can be found here:

https://sourceforge.net/projects/imdisk-toolkit/

I'll post videos as soon as I get around to making and uploading them!

A few things in the works:

    Bugs:
    Fix copy progress bar? (It never seems to get half way, maybe more testing is needed)
    Optimize remove files (Dunno if there's much to be done here, but the program hangs after a while when you remove a big chunk so for now, just let it do its thing)

    Features:
    Option to copy files from the RAMDisk to the original file location
    Status text label?
    Auto-start (Add a shortcut to your Windows startup folder and it'll automatically load up a profile and create the disk, this would be nice for when I get home from work and turn my computer on, then go wind down for a bit, come back and it's ready to go)

    Basics:
    Get a better icon (The current one looks like **** when it's that small)
