void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available())
  {
    int byteRecebido = Serial.read();
    switch(byteRecebido)
    {
      case 'a':
      Serial.write("Olá, do arduino\n");
      break;
      case 'b':
      Serial.write("Arduino é o melhor\n");
      break;
      default:
      Serial.write("Eu não conheço esse caracter!\n");
      break;
    }
  }
}
