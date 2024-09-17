using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace jwt_mvc.DAL;

public class BuildToken
{
 public string CreateToken()
 {
  var keyString = "aspnetcoreprojekampi-32bit-uzunlugunda-olacaktir";
  var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyString));
  var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

  var token = new JwtSecurityToken(
   issuer: "http://localhost",
   audience: "http://localhost",
   notBefore: DateTime.Now,
   expires: DateTime.Now.AddMinutes(1),
   signingCredentials: credentials
  );

  var handler = new JwtSecurityTokenHandler();
  return handler.WriteToken(token);
 }
}