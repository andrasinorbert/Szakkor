code	segment para	public	'code'

assume cs:code, ds:code, es:nothing, ss:nothing

	org	100h

start:
	mov	ax,3		; 85x25”s k‚perny‹ k¢dja
	int	10h			; Video Bios h¡v s -> k‚perny‹ t”rl‚s

kilep:
	mov		ah,4ch		; A kil‚p‚s k¢dja
	int		21h			; A DOS h¡v sa kil‚p‚sre
;;;;stringek:

code	ends
	end	start

