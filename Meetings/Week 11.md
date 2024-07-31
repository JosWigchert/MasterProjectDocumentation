	

Agenda
- Hardware
	- LaNA
	- SAWbird
	- Antenna
- Raw IQ samples from gr-iridium 
- Fadeprint data
	- pc vs cluster?
	- worth porting to python? (Tensorflow or PyTorch)




Extra information
- Hardware
	- LaNA
		- Might have been working a bit in the beginning?
		- Could not get it to work reliably at home
	- SAWbird
		- reliably works with the antenna
			- also works with the antenna collapsed (might even work better?)
			- could not test with other antennas due to rp-sma vs sma connectors
- IQ
	- gr-iridium only outputs the bits as far as i can see
	- I also saw found a paper where you logged the I/Q patterns from the function iridium_qpsk_demod_cpp_impl
	- https://github.com/muccc/gr-iridium/issues/48
- Fadeprint
	- I ran the run.m script on my pc which did run but took a while
	- due to python not requiring a license and being easier to implement would it be worth/preferred to try and port it to a PyTorch / tensorflow model
		- Would also make it easier to run on multiple machines with python virtual environments 

<<<<<<< HEAD

![[Pasted image 20240123231903.png]]




Questions


Action points:
- get IQ from SDR
- Look further into fadeprint
- Use Raspberry py to send messages with the limeSDR
=======
vacation mid feb

>>>>>>> c4b8db1 (Add)
