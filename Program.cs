using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var iphone14 = new Iphone("11912345678", "Iphone14", "e0e2c639-0f23-41ba-b4df-73aa5731af25", 8);
var iphone15 = new Iphone("11981991143", "Iphone15", "a363b4f1-f72a-49cc-b435-534e11a0df98", 16);
var Nokia14 = new Nokia("11986702869", "Nokia14", "6121c39b-fef4-4024-bfc5-fd433d58621b", 6);
var Nokia13 = new Nokia("11991022302", "Nokia13", "26e79cb8-7ee5-4365-a33b-11156cd19ccb", 2);

iphone14.InstalarAplicativo("WhatsApp");
iphone14.InstalarAplicativo("Super Mário");
Nokia14.InstalarAplicativo("Rastreador");
Nokia13.InstalarAplicativo("WhatsApp");