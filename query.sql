Use IFoodBanco

insert into Usuarios(email, senha, datacriacao) values('administrador@administrador.com.br', '123456', GETDATE()),
                                                      ('restaurante@restaurante.com.br', '123456', GETDATE()),
                                                      ('cliente@liente.com.br', '123456', GETDATE())

insert into Permissoes(datacriacao, Nome) values(GETDATE(),'Administrador'),
                                                (GETDATE(), 'Restaurante'),
                                                (GETDATE(), 'Cliente')

insert into UsuariosPermissoes(UsuarioId,PermissaoId, DataCriacao) values (1,1, GETDATE()), (2,2, GETDATE()),(3,3, GETDATE())

insert into Especialidades(datacriacao, Nome) VALUEs(Getdate(), 'Pizzaria'),
                                 (GETDATE(), 'Vegetariano'),
                                 (GETDATE(), 'Hamburgueria')

INSERT into Restaurantes(datacriacao, Email,EspecialidadeId,Nome,Responsavel,UsuarioId) VALUES(GETDATE(), 'pizzaria@pizzaria.com.br', 1, 'Pizzaria da Nona', 'Pietro',2),
                                (GETDATE(), 'pizzaria1@pizzaria1.com.br', 1, 'Pizzaria da Mama', 'Pierre',2),
                                (GETDATE(), 'vegeratiano@vegetariano.com.br', 2, 'Naturalistas', 'Pedro',2),
                                (GETDATE(), 'vegetariano1@vegetariano1.com.br', 2, 'Moema Natural', 'Roberto',2),
                                (GETDATE(), 'porksburguer@porksburguer.com.br', 3, 'Porks Burguer', 'Pedro',2),
                                (GETDATE(), 'hamburguerianacional@hamburguerianacional.com.br', 3, 'Hamburgueria Nacional', 'Roberto',2)

INSERT into Produtos(Ativo, DataCriacao,Nome,RestauranteId,Valor) values(1, GETDATE(), 'Pizza 4 queijos', 1, '42.00'),
                                                                        (1, GETDATE(), 'Pizza 4 queijos', 1, '42.00'),
                                                                        (1, GETDATE(), 'Pizza Mussarela', 2, '28.00'),
                                                                        (1, GETDATE(), 'Pizza Calabresa', 2, '28.00'),
                                                                        (1, GETDATE(), 'Batata Frita Vegana', 3, '18.00'),
                                                                        (1, GETDATE(), 'Strogonoff de Shitake', 3, '35.00'),
                                                                        (1, GETDATE(), 'Jaca Louca', 4, '35.00'),
                                                                        (1, GETDATE(), 'X Salada', 5, '25.00'),
                                                                        (1, GETDATE(), 'X Burguer Bacon', 6, '25.00')

insert into Clientes(DataCriacao, DataNascimento, Nome, Sexo, UsuarioId) VALUES(GetDate(), '10/10/1978 00:00:00.000', 'Fernando', 'Masculino',3)