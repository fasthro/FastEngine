--Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf.protobuf"
module('Protol.Sample2_pb')

C2S_LOGIN = protobuf.Descriptor();
C2S_LOGIN_ACCOUNT_FIELD = protobuf.FieldDescriptor();
C2S_LOGIN_PASSWORD_FIELD = protobuf.FieldDescriptor();
S2C_LOGIN = protobuf.Descriptor();
S2C_LOGIN_ACCOUNT_FIELD = protobuf.FieldDescriptor();
S2C_LOGIN_PASSWORD_FIELD = protobuf.FieldDescriptor();

C2S_LOGIN_ACCOUNT_FIELD.name = "Account"
C2S_LOGIN_ACCOUNT_FIELD.full_name = ".FastEngine.Protos.C2S_Login.Account"
C2S_LOGIN_ACCOUNT_FIELD.number = 1
C2S_LOGIN_ACCOUNT_FIELD.index = 0
C2S_LOGIN_ACCOUNT_FIELD.label = 1
C2S_LOGIN_ACCOUNT_FIELD.has_default_value = false
C2S_LOGIN_ACCOUNT_FIELD.default_value = ""
C2S_LOGIN_ACCOUNT_FIELD.type = 9
C2S_LOGIN_ACCOUNT_FIELD.cpp_type = 9

C2S_LOGIN_PASSWORD_FIELD.name = "Password"
C2S_LOGIN_PASSWORD_FIELD.full_name = ".FastEngine.Protos.C2S_Login.Password"
C2S_LOGIN_PASSWORD_FIELD.number = 2
C2S_LOGIN_PASSWORD_FIELD.index = 1
C2S_LOGIN_PASSWORD_FIELD.label = 1
C2S_LOGIN_PASSWORD_FIELD.has_default_value = false
C2S_LOGIN_PASSWORD_FIELD.default_value = ""
C2S_LOGIN_PASSWORD_FIELD.type = 9
C2S_LOGIN_PASSWORD_FIELD.cpp_type = 9

C2S_LOGIN.name = "C2S_Login"
C2S_LOGIN.full_name = ".FastEngine.Protos.C2S_Login"
C2S_LOGIN.nested_types = {}
C2S_LOGIN.enum_types = {}
C2S_LOGIN.fields = {C2S_LOGIN_ACCOUNT_FIELD, C2S_LOGIN_PASSWORD_FIELD}
C2S_LOGIN.is_extendable = false
C2S_LOGIN.extensions = {}
S2C_LOGIN_ACCOUNT_FIELD.name = "Account"
S2C_LOGIN_ACCOUNT_FIELD.full_name = ".FastEngine.Protos.S2C_Login.Account"
S2C_LOGIN_ACCOUNT_FIELD.number = 1
S2C_LOGIN_ACCOUNT_FIELD.index = 0
S2C_LOGIN_ACCOUNT_FIELD.label = 1
S2C_LOGIN_ACCOUNT_FIELD.has_default_value = false
S2C_LOGIN_ACCOUNT_FIELD.default_value = ""
S2C_LOGIN_ACCOUNT_FIELD.type = 9
S2C_LOGIN_ACCOUNT_FIELD.cpp_type = 9

S2C_LOGIN_PASSWORD_FIELD.name = "Password"
S2C_LOGIN_PASSWORD_FIELD.full_name = ".FastEngine.Protos.S2C_Login.Password"
S2C_LOGIN_PASSWORD_FIELD.number = 2
S2C_LOGIN_PASSWORD_FIELD.index = 1
S2C_LOGIN_PASSWORD_FIELD.label = 1
S2C_LOGIN_PASSWORD_FIELD.has_default_value = false
S2C_LOGIN_PASSWORD_FIELD.default_value = ""
S2C_LOGIN_PASSWORD_FIELD.type = 9
S2C_LOGIN_PASSWORD_FIELD.cpp_type = 9

S2C_LOGIN.name = "S2C_Login"
S2C_LOGIN.full_name = ".FastEngine.Protos.S2C_Login"
S2C_LOGIN.nested_types = {}
S2C_LOGIN.enum_types = {}
S2C_LOGIN.fields = {S2C_LOGIN_ACCOUNT_FIELD, S2C_LOGIN_PASSWORD_FIELD}
S2C_LOGIN.is_extendable = false
S2C_LOGIN.extensions = {}

C2S_Login = protobuf.Message(C2S_LOGIN)
S2C_Login = protobuf.Message(S2C_LOGIN)
