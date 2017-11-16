### Save IP to and set new IP

*Note: Add /sbin to PATH if ifconfig is not found*

Assuming eth0 is the interface name

Save old IP information

`ifconfig eth0 > Old_IP_Address`

Assign new IP

`sudo ifconfig eth0 add 128.10.10.10 netmask 255.255.255.255`

Verify results

`ping 128.10.10.10`

### Hostnames

Set hostname

`sudo hostname server1.example.com`

Check hostname

`hostname`

### Add User

*Note: set /usr/sbin to path if useradd not found*

`sudo useradd -s /bin/tcsh -u 6600 -c 'Student' user`

Change passwd

`sudo passwd user`

Change shell

`sudo usermod -s /bin/bash user2`

Verify results

`sudo cat /etc/passwd | grep user`

### File with touch command

Create file

`touch file`

Add contents

`cat > file`

Use `tr` to convert lowercase to uppercase and store to file

`cat file | tr [:lower:] [:upper:] > outputfile`

### Backup directory

Create dir

`mkdir dir`

Create files

`cat > file`

Create tar

`tar -cvf dir.tar dir`

### Change permissions

Create files

`touch file1 file2 file3`

Change permissions

`chmod 644 file*`

Verify results

`ls -l file*`

### Change ownership

Create file

`touch file1000`

Change ownership

`chown user:apache file1000`

Verify results

`ls -l file*`

### Backup /etc

*Note: some files may not be included because of permissions*

`tar -cvf etc.tar /etc`

### Directory Structure Tree command

Create directories recursively

`mkdir -p data/data1/data2/data3`

View with `tree`

`tree data`

### Run firefox in the background

Run firefox

`firefox &`

Get pid

`pgrep firefox`

Kill firefox (safely)

`kill -s 15 10555 # Assuming 10555 is the PID`

### Create groups and users

`groupadd mcausers`

`groupadd bcausers`

`useradd user1`

`useradd user2`

`usermod -aG mcausers,bcausers user1`

`usermod -aG mcausers,bcausers user2`

### Schedule a job

Get TTY from `who` command

`(who | grep $(whoami) | awk '{ print $2 }'`

Assuming the tty is `tty1`

`at 15:30 Jan 30`

`at> echo wElCoMe > /dev/tty1`

Exit with Ctrl+D

*Note: This may not actually work depending on the system. An alternative approach is given below*

`touch /tmp/somefile`

`at 15:30 Jan 30`

`at> echo wElCoMe > /tmp/somefile`

Exit with Ctrl+D

This will automatically show changes in `somefile`

`tail -f /tmp/somefile`

### Chagne runlevel

Show runlevel

`runlevel`

Set to CLI mode

`init 3`

Reboot

`init 6`

Set to GUI mode

`init 5`

### Set sticky bit

*Note, the sticky bit is not the same as SETUID / SETGID. See: https://unix.stackexchange.com/questions/79395/how-does-the-sticky-bit-work for more details*

`mkdir CommonData`

`chmod +s CommonData`

### Save contents using the vi editor

`vi file1 file2`

Add text to file1

Change buffers (open files) with `:bn` in normal mode

Write changes to `file3` by appending current contents. Do this for both files

`:w >> file3` 

## Dec 2010

*These are less likely, perhaps*

### Nice and Renice

Remember `nice` value is opposite to priority i.e. lower the value, higher the priority

First get the `ppid` of a process

`ps -eo ppid,cmd | grep firefox`

Assuming the ppid is 2344

`nice -20 2344`

`renice -20 2344`

### Soft links and Hard Links

Create original file

`touch file`

Create soft link

`ln -s file shortcut-to-file`

Create hard link

`ln file shortcut-to-file-hard`




